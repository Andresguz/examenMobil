using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject _laserPrefab;
    private float _fireRate = 0.5f;
    private float _canFire = 0.0f;
    private bool shotNow;
    float next;
    public GameObject _laserPos;
    public AudioSource _audioSource;    
    public AudioClip _laserClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("a");
            FireLaser();
           
        }
    
    }
  public  void FireLaser()
    {
        if (Time.time>next )
        {
            next = Time.time+_fireRate;
            Instantiate(_laserPrefab, _laserPos.transform);
            _audioSource.PlayOneShot(_laserClip);
        }
     
           
    }

}
