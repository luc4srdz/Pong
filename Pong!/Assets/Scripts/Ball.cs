using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed;
    private IEnumerator Launch()
    {
        yield return new WaitForSeconds(1);
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ball.velocity = new Vector2(speed * x, speed * y);
    }
    public void ResetPosition()
    {
        ball.position = Vector2.zero;
        ball.velocity = Vector2.zero;
        StartCoroutine(Launch());
    }
    private void Start()
    {
        StartCoroutine(Launch());
    }
}