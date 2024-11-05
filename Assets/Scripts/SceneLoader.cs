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
        Bedroom
    }
    public static void OnPlayButton()
    {
        SceneManager.LoadScene((int)Scenes.Kitchen);
    }

    public static void OnNextLevelButton()
    {
        if (SceneManager.GetActiveScene().name == Scenes.Study.ToString())
        {
            SceneManager.LoadScene((int)Scenes.Bedroom);
        }
        else
        {
            SceneManager.LoadScene((int)Scenes.Study);
        }
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
