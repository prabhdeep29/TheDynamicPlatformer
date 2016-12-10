using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string startLevel;

    public void NewGame()
    {
         Application.LoadLevel (startLevel);
    }


    public void QuitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }
    }