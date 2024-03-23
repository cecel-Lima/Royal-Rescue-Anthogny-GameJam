using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Button_1;

    // Start is called before the first frame update
    private void Start()
    {
        Resume();
    }

    // Update is called once per frame
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
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Button_1.gameObject.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Button_1.gameObject.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Repeteco()
    {
        SceneManager.LoadScene((2));
        pauseMenuUI.SetActive(false);
        Button_1.gameObject.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
