using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFlipper : MonoBehaviour
{
    
    public void PlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(4);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}

