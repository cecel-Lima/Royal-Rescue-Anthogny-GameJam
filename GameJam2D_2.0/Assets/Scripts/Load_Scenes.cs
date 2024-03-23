using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scenes : MonoBehaviour
{
    //AudioManager audioManager;

    //private void Awake()
    //{
    //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    //}

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Defeat_Screen"))
        //{
            //audioManager.PlaySFX(audioManager.derrota);
        //}
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadCreditos()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadVictory()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadDefeat()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadSair()
    {
        Application.Quit();
    }
}
