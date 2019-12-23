using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float JumpForce;
    public Rigidbody2D rb;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
          rb.AddForce(transform.up*JumpForce);
          Debug.Log("osjfaehfw");
        }


     Debug.Log("osjfaehfw");
        
       
    }
}
