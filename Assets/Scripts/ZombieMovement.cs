using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float zombieMovementSpeed = 5f;

    private Rigidbody2D zombieRB;
    void Start()
    {
        zombieRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(-zombieMovementSpeed * Time.deltaTime, 0, 0);
    }
}
