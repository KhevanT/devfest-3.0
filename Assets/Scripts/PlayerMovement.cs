using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Level level;
    public int x, y;
    [System.NonSerialized] public float targetX, targetY;
    public float speed;
    bool canMove = true;

    // for some reason, if you want to prevent player movement in a specific direction despite the previous conditions then control these parameters
    [System.NonSerialized]public bool blockLeft = false, blockRight = false, blockUp = false, blockDown = false;

    private void Start()
    {
        transform.position = new Vector2(x * level.tileLength + 0.5f, y * level.tileLength + 0.5f);
        targetX = transform.position.x;
        targetY = transform.position.y;
        Debug.Log(transform.position);
        Debug.Log(targetX + " " + targetY);
    }

    private void Update()
    {
        // Khevan: please use CheckCollision() to see if movement can proceed!!

        if (transform.position.x == targetX && transform.position.y == targetY)
        {
            canMove = true;
            x = (int)(transform.position.x - 0.5f)/level.tileLength;
            y = (int)(transform.position.y - 0.5f)/level.tileLength;
        }
        else // Khevan: I believe the collision error is happening here, i dont think code ever enters this else block
        {
            canMove = false;
            float t = Time.deltaTime * speed;
            transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(targetX, targetY), t);
        }

        doInput();

        Debug.Log(transform.position);
        Debug.Log(targetX + " " + targetY);
    }

    private void doInput()
    {
        if (Input.GetKeyDown("a") && canMove && level.CanPlayerMoveLeft(x, y) && !blockLeft)
        {
            targetX = transform.position.x - level.tileLength;
        }
        if (Input.GetKeyDown("d") && canMove && level.CanPlayerMoveRight(x, y) && !blockRight)
        {
            targetX = transform.position.x + level.tileLength;
        }
        if (Input.GetKeyDown("w") && canMove && level.CanPlayerMoveUp(x, y) && !blockUp)
        {
            targetY = transform.position.y + level.tileLength;
        }
        if (Input.GetKeyDown("s") && canMove && level.CanPlayerMoveDown(x, y) && !blockDown)
        {
            targetY = transform.position.y - level.tileLength;
        }
    }

    // Khevan: new function that checks if there are any collisions in next move 
    // returns if you can proceed
    private bool checkCollision()
    {
        bool proceed = true;

        // < write code to check for collision based on level > 
        // try using OnCollisionEnter2D(Collision2D collision) ?

        return proceed;
    }
}
