using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Rigidbody2D paddle;
    public string axis;
    public float speed;
    private float direction;
    private void Update()
    {
        direction = Input.GetAxisRaw(axis);
        paddle.velocity = new Vector2(paddle.velocity.x, direction * speed);
    }
}