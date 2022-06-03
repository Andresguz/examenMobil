using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject _laserPrefab;
    private float _fireRate = 0.2f;
    private float _canFire = 0.0f;
    public GameObject _laserPos;
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
        //Vector3 offsetY = new Vector3(0, 1.05f, 0);

        //canfire = 1.0f + 0.2f is time.time 1.1f > _canFire no so you cannot shoot
        //_canFire = Time.time + _fireRate;
            Instantiate(_laserPrefab, _laserPos.transform);
    }

}
