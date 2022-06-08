using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AI : MonoBehaviour
{
    public Rigidbody2D paddle;
    public Rigidbody2D ball;
    public float speed;
    private float direction;
    private void Update()
    {
        if(ball.velocity.x > 0)
        {
            if(ball.position.y > paddle.position.y + 1)
            {
                direction = 1;
            }
            else if(ball.position.y < paddle.position.y - 1)
            {
                direction = -1;
            }
            else
            {
                direction = 0;
            }
        }
        else
        {
            if(paddle.position.y > 0.5)
            {
                direction = -1;
            }
            else if(paddle.position.y < -0.5)
            {
                direction = 1;
            }
            else
            {
                direction = 0;
            }
        }
        paddle.velocity = new Vector2(paddle.velocity.x, direction * speed);
    }
}