using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEnemy : MonoBehaviour
{
    private float tiempo;
    public GameObject bulletEnemy;
    public Transform PosShot;
    public AudioSource au;
    public AudioClip des;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo >= 3)
        {
            au.PlayOneShot(des);
            Instantiate(bulletEnemy, PosShot.position, Quaternion.identity);
            tiempo = 0;
        }
    }
}
