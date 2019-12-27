using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
     public Text coinText;
     public int coins;
    void Update()
    {
        coinText.text = "" + coins;
        coins = PlayerPrefs.GetInt("Coins");
        
        
    }
}
