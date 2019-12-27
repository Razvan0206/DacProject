using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int count,count2;
    Vector2 nextPos;
    float nextY,timer,nextY2,nextY3;
    public GameObject platform,coins,bg;
    // Start is called before the first frame update
    void Start()
    {

        timer = 2;
        nextY2 = 5;
        PlayerPrefs.SetInt("Count", 8);
        count = 1;
        nextY = -2;
        nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
        Instantiate(platform, nextPos, transform.rotation);
        while (count < 8)
        {
            nextY += Random.Range(3, 3.5f);
            nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            count++;
        }
        PlayerPrefs.SetInt("Count2", 8);
        count2 = 1;
        nextY3 = 0;
        nextPos = new Vector2(0, nextY3);
        Instantiate(bg, nextPos, transform.rotation);
        while (count2 < 8)
        {
            nextY3 += 10;
            nextPos = new Vector2(0, nextY3);
            Instantiate(bg, nextPos, transform.rotation);
            count2++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(coins, new Vector2(Random.Range(-1.5f, 1.5f), transform.position.y+nextY2), transform.rotation);
            nextY2 += Random.Range(10, 12);
            timer = 2;
        }
        if(count > PlayerPrefs.GetInt("Count"))
        {
            nextY += Random.Range(3, 3.5f);
            nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            PlayerPrefs.SetInt("Count", 8);
        }
        if (count2 > PlayerPrefs.GetInt("Count2"))
        {
            nextY3 += 10;
            nextPos = new Vector2(0, nextY3);
            Instantiate(bg, nextPos, transform.rotation);
            PlayerPrefs.SetInt("Count2", 8);
        }
    }
}
