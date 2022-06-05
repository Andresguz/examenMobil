using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4.0f;
    
    private bool _isHit = false;


    void Start()
    {
      //  _explSrc = GetComponent<AudioSource>();
        transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 7.5f, 0);
    
      //  _animator = GetComponent<Animator>();
    }
    void Update()
    {
        Vector3 enemyMovement = Vector3.down * _enemySpeed * Time.deltaTime;
        transform.Translate(enemyMovement);
        Vector3 respawnTop = new Vector3(Random.Range(-8.0f, 8.0f), 7.5f, 0);
        if (transform.position.y <= -5.5f)
        {
            transform.position = respawnTop;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        life player = other.transform.GetComponent<life>();
        if (other.tag == "Player")
        {
            _enemySpeed = 0;
            player.vidaP -= 10;
          //  Destroy(this.gameObject);
        }




    }
}
