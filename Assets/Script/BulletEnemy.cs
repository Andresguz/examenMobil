using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
   
    Rigidbody2D rb;

    public float speed = 2;
    move target;
    Vector2 moveDirection;
    public GameObject fbx;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<move>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 4f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //    if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("piso"))
        //    {
        //        Instantiate(destruccion, collision.transform);
        //        Destroy(gameObject, 0.2f);
        //    }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life player = collision.transform.GetComponent<life>();
            Instantiate(fbx,collision.transform);
            player.vidaP -= 10;
            Destroy(gameObject, 0.2f);
        }
    }
}
