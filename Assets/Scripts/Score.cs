using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public Text HighScoreText;

    public float pos;
    public float maximum;
    public float score;
    void Update()
    {
        if (pos > maximum)
        {
            maximum = pos;
        }
        score = maximum;
        pos = player.position.y;

        scoretext.text = score.ToString("0");
        if(PlayerPrefs.GetInt("HighScore") < maximum)
        {
            PlayerPrefs.SetInt("HighScore", (int)maximum);
        }
        HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }



}
