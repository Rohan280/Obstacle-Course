using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerIntructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PlayerIntructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move the player using WASD or Arrow Keys");
        Debug.Log("Enjoy");
    } 

    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xvalue, 0, zvalue);
    }
}
