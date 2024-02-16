using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonMaster : MonoBehaviour
{
    public AudioSource audio;
    public string sceneName;
    public string mainMenuScene;
    public GameObject Main;
    public GameObject Settings;
    public GameObject PauseMenu;
    public void ExitGame()
    {
        ExitGame();
        Debug.Log("ExitGame");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
        
    }

    public void soundTest()
    {
        audio.Play();
    }
    public void ToSettings()
    {
        Main.SetActive(false);
        Settings.SetActive(true);
    }
    public void ToMenu()
    {
        Main.SetActive(true);
        Settings.SetActive(false);
    }

    public void backToGame()
    {
        PauseMenu.SetActive(false);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("TweeKamers");
    }


}
