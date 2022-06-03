using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaENEMY : MonoBehaviour
{
    public Slider slider;
    public DestroyEnemy enemy;
    private void Start()
    {

    }
    private void Update()
    {
        slider.value = enemy.vidaE;

        if (enemy.vidaE == 0)
        {

            Destroy(gameObject);
        }
    }


}