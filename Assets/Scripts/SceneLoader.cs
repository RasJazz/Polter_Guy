using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private enum Scenes
    {
        Start,
        Kitchen,
        Study,
        //Bedroom
    }
    public static void OnPlayButton()
    {
        SceneManager.LoadScene((int)Scenes.Kitchen);
    }

    public static void OnMainMenuButton()
    {
        SceneManager.LoadScene((int)Scenes.Start);
    }
    
    public static void OnNextLevelButton()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        
        Debug.Log(currentScene);
        if (currentScene == "Kitchen")
        {
            SceneManager.LoadScene((int)Scenes.Study);
        }
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
