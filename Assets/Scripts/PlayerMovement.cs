using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int x, y;
    float targetX, targetY;
    public float speed;
    bool canMove = true;
    public Level level;

    private void Start()
    {
        transform.position = new Vector2(x * level.tileLength + 0.5f, y * level.tileLength + 0.5f);
        targetX = transform.position.x;
        targetY = transform.position.y;
    }

    private void Update()
    {
        if (transform.position.x == targetX && transform.position.y == targetY)
        {
            canMove = true;
            x = (int)(transform.position.x - 0.5f)/level.tileLength;
            y = (int)(transform.position.y - 0.5f)/level.tileLength;
        }
        
        else {
            canMove = false;
            float t = Time.deltaTime * speed;
            transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(targetX, targetY), t);
        }

        if (Input.GetKeyDown("a") && canMove && level.CanPlayerMoveLeft(x, y)) {
            targetX = transform.position.x - level.tileLength;
        }
        if (Input.GetKeyDown("d") && canMove && level.CanPlayerMoveRight(x, y))
        {
            targetX = transform.position.x + level.tileLength;
        }
        if (Input.GetKeyDown("w") && canMove && level.CanPlayerMoveUp(x, y))
        {
            targetY = transform.position.y + level.tileLength;
        }
        if (Input.GetKeyDown("s") && canMove && level.CanPlayerMoveDown(x, y))
        {
            targetY = transform.position.y - level.tileLength;
        }
    }
}
