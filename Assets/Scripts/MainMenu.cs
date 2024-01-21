using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Loads first level scene
    public void PlayButtonClick()
    {
        SceneManager.LoadScene("SampleScene"); // PLACEHOLDER SCENE NAME
    }

    // Quits game
    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
