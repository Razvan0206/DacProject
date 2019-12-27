using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public float pos;
    public float maximum;
    public float score;
    void Update()
    {
        if (pos > maximum)
        {
            maximum = pos;
        }
        score = maximum / 3;
        pos = player.position.y;

        scoretext.text = score.ToString("0");
    }


}
