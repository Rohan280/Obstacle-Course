using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] Rigidbody rb;
    float xvalue;
    float zvalue;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        PlayerIntructions();
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void HandleInput()
    {
        xvalue = Input.GetAxis("Horizontal") * moveSpeed;
        zvalue = Input.GetAxis("Vertical") * moveSpeed;
    }

    void PlayerIntructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move the player using WASD or Arrow Keys");
        Debug.Log("Enjoy");
    } 

    void MovePlayer()
    {

        rb.velocity = new Vector3(xvalue, 0, zvalue);
        

        //transform.Translate(xvalue, 0, zvalue);
    }
}
