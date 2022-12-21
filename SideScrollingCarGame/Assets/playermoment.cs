using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoment : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(MoveX, MoveY);
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
