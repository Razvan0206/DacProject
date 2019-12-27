using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int count;
    Vector2 nextPos;
    float nextY,timer,nextY2;
    public GameObject platform,coins;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        nextY2 = 5;
        PlayerPrefs.SetInt("Count", 4);
        count = 1;
        nextY = -2;
        nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
        Instantiate(platform, nextPos, transform.rotation);
        while (count < 4)
        {
            nextY += Random.Range(3, 3.5f);
            nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            count++;
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
            timer = 5;
        }
        if(count > PlayerPrefs.GetInt("Count"))
        {
            nextY += Random.Range(3, 3.5f);
            nextPos = new Vector2(Random.Range(-1.5f, 1.5f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            PlayerPrefs.SetInt("Count", 4);
        }
    }
}
