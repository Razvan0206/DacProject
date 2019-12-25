using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int count;
    Vector2 nextPos;
    float nextY;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Count", 4);
        count = 1;
        nextY = -2;
        nextPos = new Vector2(Random.Range(-1.4f, 1.4f), nextY);
        Instantiate(platform, nextPos, transform.rotation);
        while (count < 4)
        {
            nextY += Random.Range(2, 2.5f);
            nextPos = new Vector2(Random.Range(-1.4f, 1.4f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            count++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(count > PlayerPrefs.GetInt("Count"))
        {
            nextY += Random.Range(2, 2.5f);
            nextPos = new Vector2(Random.Range(-1.4f, 1.4f), nextY);
            Instantiate(platform, nextPos, transform.rotation);
            count++;
        }
    }
}
