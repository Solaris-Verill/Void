using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas main;
    public Canvas Credits;
    public Canvas Controls;
    public Canvas GameOver;
    public Canvas Win;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (PlayerPrefs.GetInt("Start") == 0)
        {
            MainMenuCanvas();
        }
        else
        {

            if (PlayerPrefs.GetInt("HP") == 0)
            {
                GameOverCanvas();
            }
            else if (PlayerPrefs.GetInt("Coins") == 4)
            {
                WinCanvas();
            }
            else
            {
                MainMenuCanvas();
            }
        }
    }

    public void PlayGame()
    {
        PlayerPrefs.SetInt("Start", 1);
        SceneManager.LoadSceneAsync("Main");
    }

    public void MainMenuCanvas()
    {
        main.enabled = true;
        Credits.enabled = false;
        Controls.enabled = false;
        GameOver.enabled = false;
        Win.enabled = false;
    }

    public void CreditsCanvas()
    {
        main.enabled = false;
        Credits.enabled = true;
        Controls.enabled = false;
        GameOver.enabled = false;
        Win.enabled = false;
    }

    public void ControlsCanvas()
    {
        main.enabled = false;
        Credits.enabled = false;
        Controls.enabled = true;
        GameOver.enabled = false;
        Win.enabled = false;
    }

    public void GameOverCanvas()
    {
        main.enabled = false;
        Credits.enabled = false;
        Controls.enabled = false;
        GameOver.enabled = true;
        Win.enabled = false;
    }

    public void WinCanvas()
    {
        main.enabled = false;
        Credits.enabled = false;
        Controls.enabled = false;
        GameOver.enabled = false;
        Win.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Start", 0);
    }
}
