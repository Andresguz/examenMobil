using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEnemy : MonoBehaviour
{
    //public GameObject eliminacion;

    public int vidaE = 100;
    private void Start()
    {

    }
    private void Update()
    {
       
        if (vidaE == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("laser"))
        {
            vidaE -= 50;

            //  Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {


            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
