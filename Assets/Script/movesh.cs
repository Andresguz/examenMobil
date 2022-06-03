using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesh : MonoBehaviour
{
   
   


    void Start()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 3.5f, 0);
    }
    void Update()
    {
      
        Vector3 respawnTop = new Vector3(Random.Range(-8.0f, 8.0f), 3.5f, 0);
        if (transform.position.y <= -5.5f)
        {
            transform.position = respawnTop;
        }
    }

    
}
