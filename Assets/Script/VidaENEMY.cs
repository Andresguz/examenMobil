using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaENEMY : MonoBehaviour
{
    public Slider slider;
    public DestroyEnemy enemy;
    GameManager gameManager;
     void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
     void Update()
    {
        slider.value = enemy.vidaE;

        if (enemy.vidaE == 0)
        {
            gameManager.scorep++;
            Destroy(gameObject);
        }
    }


}