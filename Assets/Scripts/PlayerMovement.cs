using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed at which the player moves
    public float movementSpeed = 10f;

    //The player's Rigidbody
    Rigidbody2D playerRb;
    void Start()
    {
        //Get the player's rigidbody
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //If W is pressed, move up
        if (Input.GetKey(KeyCode.W))
        {
            //If the player is not at the top of the screen, move up
            if (transform.position.y <= 4.3)
            {
                transform.position = transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
            }
        }

        //If S is pressed, move down
        if (Input.GetKey(KeyCode.S))
        {
            //If the player is not at the bottom of the screen, move down
            if (transform.position.y >= -4.3)
            {
                transform.position = transform.position + new Vector3(0, -movementSpeed * Time.deltaTime, 0);
            }
        }

    }
}
