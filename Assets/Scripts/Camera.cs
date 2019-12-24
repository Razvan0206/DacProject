using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform Player;
    public GameObject PlayerGam;
    public float PlayerY1;
    public float PlayerY2;
    public Vector3 offset;
    
     void Update()
    {
       Follow();
        
      Vector3 playerPosition = Player.position;
      PlayerY1 = playerPosition.y;
  
    }
    
    public void Follow()
    {
        Debug.Log("Following");
        Vector3 position = transform.position ;
      position.y = (Player.position + offset).y ;
      
      transform.position = position ;
    }

}
 


