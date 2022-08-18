using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Platform : MonoBehaviour
{
    public GameObject ball;
    Vector2 firstPosBall,endPosBall;

    // Update is called once per frame
    void Update()
    {
        loadMenu();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if(collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<Ball>().jump();
                collision.gameObject.GetComponent<Ball>().changeColor();
                collision.gameObject.GetComponent<Ball>().audio();
                Destroy(gameObject);
            }

            firstPosBall = ball.transform.position;
        }
    }

    void loadMenu()
    {
        endPosBall = ball.transform.position;

        if(firstPosBall.y > endPosBall.y + 4)
        {
            SceneManager.LoadScene("menu");
        }
    }


}
