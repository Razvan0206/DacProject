using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool time = false;
    public Canvas PauseCavas;
    public void Pause1()
    {
        time = ! time;
        
    }
    public void Update()
    {
        if (time == true)
        {
            Time.timeScale = 0;
            PauseCavas.enabled = true;
        }
        if (time == false)
        {
            Time.timeScale = 1;
            PauseCavas.enabled = false;
        }
    }
    public void Resume()
    {
        time = false;
        PauseCavas.enabled = false;
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
