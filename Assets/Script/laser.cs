using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
  
    [SerializeField]
    private float _laserSpeed = 8f;


    void Update()
    {

        Vector3 laserDir = Vector3.up * _laserSpeed * Time.deltaTime;
        transform.Translate(laserDir);

        if (transform.position.y > 8.5f)
        {
            
            {
                //Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(this.gameObject);
        }
    }
}
