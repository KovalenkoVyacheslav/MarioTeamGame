using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void NewGame()
    {
        Scores.scr = 0;
        SceneManager.LoadScene("Level1");
    }

    public void GameQuit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
