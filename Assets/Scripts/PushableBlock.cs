using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableBlock : MonoBehaviour
{
    public Level level;
    public PlayerMovement playerMovement;
    // public PlayerStateHandler playerStateHandler;
    public int x, y;
    float targetX, targetY;
    public float speed;
    bool canMove = true;

    private int playerX, playerY;

    void Start()
    {
        transform.position = new Vector2(x * level.tileLength + 0.5f, y * level.tileLength + 0.5f);
        targetX = transform.position.x;
        targetY = transform.position.y;

        playerX = playerMovement.x;
        playerY = playerMovement.y;
    }

    void Update()
    {
        doMovement();
        if (transform.position.x == targetX && transform.position.y == targetY)
        {
            canMove = true;
            x = (int)(transform.position.x - 0.5f) / level.tileLength;
            y = (int)(transform.position.y - 0.5f) / level.tileLength;
        }

        else
        {
            canMove = false;
            float t = Time.deltaTime * speed;
            transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(targetX, targetY), t);
        }
    }

    void doMovement() {

        // player is pushing from the left
        if (playerMovement.x == x - 1 && playerMovement.y == y)
        {
            if (!level.CanPlayerMoveRight(x, y))
            {
                playerMovement.blockRight = true;
            }
            else
            {
                if (playerMovement.targetX == transform.position.x && playerMovement.targetY == transform.position.y)
                {
                    targetX = playerMovement.targetX + level.tileLength;
                    level.pushRight(x, y);
                }
            }
        }

        // player is pushing from right
        else if (playerMovement.x == x + 1 && playerMovement.y == y)
        {
            if (!level.CanPlayerMoveLeft(x, y))
            {
                playerMovement.blockLeft = true;
            }
            else
            {
                if (playerMovement.targetX == transform.position.x && playerMovement.targetY == transform.position.y)
                {
                    targetX = playerMovement.targetX - level.tileLength;
                    level.pushLeft(x, y);
                }
            }
        }

        // player is pushing from below
        else if (playerMovement.x == x && playerMovement.y == y - 1)
        {
            if (!level.CanPlayerMoveUp(x, y))
            {
                playerMovement.blockUp = true;
            }
            else
            {
                if (playerMovement.targetX == transform.position.x && playerMovement.targetY == transform.position.y)
                {
                    targetY = playerMovement.targetY + level.tileLength;
                    level.pushUp(x, y);
                }
            }
        }

        // player is pushing from above
        else if (playerMovement.x == x && playerMovement.y == y + 1)
        {
            if (!level.CanPlayerMoveDown(x, y))
            {
                playerMovement.blockDown = true;
            }
            else
            {
                if (playerMovement.targetX == transform.position.x && playerMovement.targetY == transform.position.y)
                {
                    targetY = playerMovement.targetY - level.tileLength;
                    level.pushDown(x, y);
                }
            }
        }

        else
        {
            playerMovement.blockDown = false;
            playerMovement.blockLeft = false;
            playerMovement.blockRight = false;
            playerMovement.blockUp = false;
        }
    }
}
