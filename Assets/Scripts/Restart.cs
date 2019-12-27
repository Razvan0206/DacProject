using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Restart : MonoBehaviour
{
    public Transform Nava;
    public Transform Camera;
    public Transform Player;
    public Canvas RestartCan;
    
    public void Continue()
    {
        if(Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show("rewardedVideo");
            Nava.position = new Vector3(Nava.position.x, Camera.position.y - 4, Nava.position.z);
            Player.position = new Vector3(Camera.position.x, Camera.position.y, Player.position.z);
            RestartCan.enabled = false;
        }
        
    }
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
