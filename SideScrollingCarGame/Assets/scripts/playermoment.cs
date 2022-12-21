using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoment : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update() //gets an input and makes a new vector2 named movedirection
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(MoveX, MoveY);
    }
    void FixedUpdate() //decides where to move the car and at what speed. The car could move at any axis but the movement has been locked in the unity editor
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
