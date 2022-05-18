using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

        void Resume()
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        void Pause()
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        void LoadMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("SampleScene");
        }

    }
}
