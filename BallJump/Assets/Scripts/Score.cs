using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreValue,highScoreValue;
    public Text scoreText, highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        highScoreValue = PlayerPrefs.GetInt(nameof(highScoreValue));        
    }

    // Update is called once per frame
    void Update()
    {
        highScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            if(collision.relativeVelocity.y >= 0f)
            {
                score();
            }
            
        }
    }

    void score()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString();
    }

    void highScore()
    {
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetInt(nameof(highScoreValue), highScoreValue);
        }
        highScoreText.text = highScoreValue.ToString();
    }
}
