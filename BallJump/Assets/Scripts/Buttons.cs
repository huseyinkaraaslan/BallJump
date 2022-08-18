using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    bool gamePause = false;
    public GameObject playButtonImage;
    public GameObject pauseButtonImage;
    private void Start()
    {
        pauseButtonImage.SetActive(true);
        playButtonImage.SetActive(false);
    }
    public void playbutton()
    {
        SceneManager.LoadScene("level");
    }

    public void pauseButton()
    {
        if (!(gamePause))
        {
            Time.timeScale = 0f;
            playButtonImage.SetActive(true);
            pauseButtonImage.SetActive(false);
            gamePause = true;
        }
        else if(gamePause)
        {
            Time.timeScale = 1f;
            playButtonImage.SetActive(false);
            pauseButtonImage.SetActive(true);
            gamePause = false;
        }
    }

}
