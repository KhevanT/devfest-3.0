using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        SoundManager.Instance.PlayMusic("Main Menu");
    }

    // Loads first level scene
    public void PlayButtonClick()
    {
        SoundManager.Instance.PlaySFX("Button Click");
        SceneManager.LoadScene("SampleScene"); // PLACEHOLDER SCENE NAME
    }

    // Quits game
    public void QuitButtonClick()
    {
        SoundManager.Instance.PlaySFX("Button Click");
        Application.Quit();
    }
}
