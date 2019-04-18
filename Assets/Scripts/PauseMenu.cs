using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseObject;
    bool FlagPause = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (FlagPause)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseObject.SetActive(false);
        FlagPause = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseObject.SetActive(true);
        FlagPause = true;
        Time.timeScale = 0f;
    }

    public void QuitFromGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void LoadMenuScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
