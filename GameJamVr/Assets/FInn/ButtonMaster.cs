using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonMaster : MonoBehaviour
{
    public AudioSource audio;
    public string sceneName;
    public GameObject Main;
    public GameObject Settings;
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


}
