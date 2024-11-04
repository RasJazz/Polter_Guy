using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static void OnPlayButton()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
