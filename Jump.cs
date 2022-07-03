using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //Variable Declaration
    public float JumpForce;
    bool isJumping;
    public Vector2 velocity;
 
    void Start()
    {
        isJumping = false;
    }

    void Update()
    {
        Jump();
    }

    //Jump Method
    void Jump()
    {
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = Vector2.up * JumpForce;
            isJumping = true;
        }
    }

    //Jump Restriction
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }
}