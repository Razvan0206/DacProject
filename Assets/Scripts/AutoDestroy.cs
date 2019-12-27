using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    Collider2D coll;
    public GameObject ply;
    float dist;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
        ply = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ply.transform.position.y - transform.position.y);
        dist = Mathf.Abs(transform.position.y - ply.transform.position.y);
        if(ply.transform.position.y - transform.position.y >= 0.5f)
        {
            coll.enabled = true;
        }
        else
        {
            coll.enabled = false;
        }
    }

    private void OnBecameInvisible()
    {
        if (dist > 0)
        {
            PlayerPrefs.SetInt("Count", 7);
            Destroy(this.gameObject);
        }   
    }
}
