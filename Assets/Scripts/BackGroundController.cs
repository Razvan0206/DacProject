using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    public GameObject ply;
    float dist;
    // Start is called before the first frame update
    void Start()
    {
        ply = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.Abs(transform.position.y - ply.transform.position.y);
    }

    private void OnBecameInvisible()
    {
        if (dist > 0)
        {
            PlayerPrefs.SetInt("Count2", 7);
            Destroy(this.gameObject);
        }
    }
}
