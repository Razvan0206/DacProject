using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float JumpForce;
    public float SidewaysForce;
    public bool left;
    public bool right;
    public Rigidbody2D rb;
    public AudioManager Audio;
    public Canvas restart;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" )
        {
            rb.AddForce(transform.up * JumpForce);
            Debug.Log("GroundCollide");
        }
        
        if (collision.gameObject.tag == "DeathGround")
        {
            Invoke("Death", 2.5f);
            Audio.Explosion();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            Audio.Coin();

        }
        if (collision.gameObject.tag == "Gasoline")
        {
            rb.AddForce(transform.up * JumpForce * 3);
            Destroy(collision.gameObject);
        }

    }

    void Update()
    {
        //A
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }
        //
        //B
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }
        //
        if (left == true)
        {
            rb.AddForce(transform.right * -SidewaysForce);
            Debug.Log("left");
        }
        if (right == true)
        {
            rb.AddForce(transform.right * SidewaysForce);
            Debug.Log("right");
        }
        


    }
    public void leftD()
    {
        left = true;
    }
    public void leftU()
    {
        left = false;
    }
    public void RightD()
    {
        right = true;
    }
    public void RightU()
    {
        right = false;
    }
    public void Death()
    {
        
        restart.enabled = true;
    }

}
