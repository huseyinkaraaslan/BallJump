using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    int colorValue;
    Touch finger;
    Vector2 firstPos, endPos;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    public void movement()
    {
        if(Input.touchCount > 0)
        {
            finger = Input.GetTouch(0);

            if(finger.phase == TouchPhase.Began)
            {
                firstPos = finger.position;
                endPos = finger.position;
            }

            if(finger.phase == TouchPhase.Moved)
            {
                endPos = finger.position;
            }

            if(finger.phase == TouchPhase.Ended)
            {
                firstPos = finger.position;
                endPos = finger.position;
            }
        }

        Vector3 temp = (endPos-firstPos).normalized;
        transform.Translate(temp.x / 30, 0, 0);

    }

    public void jump()
    {
        rb.velocity = new Vector2(0, 7);
    }

    public void audio()
    {
        audioSource.Play();
    }

    public void changeColor()
    {
        colorValue = Random.Range(1, 7);
        switch (colorValue)
        {
            case 1: gameObject.GetComponent<Renderer>().material.color = Color.green;
                    gameObject.GetComponent<Score>().scoreText.color = Color.green;
                    break;
            case 2: gameObject.GetComponent<Renderer>().material.color = Color.red;
                    gameObject.GetComponent<Score>().scoreText.color = Color.red;
                    break;
            case 3: gameObject.GetComponent<Renderer>().material.color = Color.white;
                    gameObject.GetComponent<Score>().scoreText.color = Color.white;
                    break;
            case 4: gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                    gameObject.GetComponent<Score>().scoreText.color = Color.cyan;
                    break;
            case 5: gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                    gameObject.GetComponent<Score>().scoreText.color = Color.yellow;
                    break;
            case 6: gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                    gameObject.GetComponent<Score>().scoreText.color = Color.magenta;
                    break;

        }
    }
}
