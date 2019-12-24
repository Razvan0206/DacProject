using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     public Text coinText;
     public int coins;
    void Update()
    {
        coinText.text = "Coins: " + coins;
        coins = PlayerPrefs.GetInt("Coins");
        
        
    }
}
