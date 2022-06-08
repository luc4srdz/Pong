using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI score_text;
    private int score = 0;
    private void OnCollisionEnter2D()
    {
        score++;
        this.score_text.text = score.ToString();
        this.ball.ResetPosition();
    }
}