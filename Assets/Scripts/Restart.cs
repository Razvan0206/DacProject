using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public Transform Nava;
    public Transform Camera;
    public Transform Player;
    public Canvas RestartCan;
    
    
    public void Restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
