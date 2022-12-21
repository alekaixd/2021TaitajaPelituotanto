using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); // moves the object this script has been assigned to left
    }
}
