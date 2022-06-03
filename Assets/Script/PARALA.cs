using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PARALA : MonoBehaviour
{
    [SerializeField]
    float shiftMoodifier;
    private Gyroscope gyroo;
    private void Start()
    {
        gyroo = Input.gyro;
        gyroo.enabled = true;
    }
    private void Update()
    {
        transform.Translate((float)System.Math.Round(gyroo.rotationRateUnbiased.y, 1) * shiftMoodifier, 0f, 0f);
    }
}
