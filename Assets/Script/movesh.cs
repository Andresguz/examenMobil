using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movesh : MonoBehaviour
{


    public float _enemySpeed;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 3.5f, 0);
    }
    void Update()
    {
      
      //  Vector3 respawnTop = new Vector3(Random.Range(-8.0f, 8.0f), 3.5f, 0);
        //if (transform.position.y <= -5.5f)
        //{
        //    transform.position = respawnTop;
        //}


        Vector3 enemyMovement = Vector3.right * _enemySpeed * Time.deltaTime;
        transform.Translate(enemyMovement);
        Vector3 respawnTop = new Vector3(Random.Range(-8.0f, 8.0f), 4.2f, 0);
        if (transform.position.x >= 8f)
        {
            transform.position = respawnTop;
        }
    }

    
}
