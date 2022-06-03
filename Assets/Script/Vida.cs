using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public float vida = 100;
    public Slider sliderVida;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderVida.value = vida;

        if (vida == 0)
        {

            Destroy(gameObject);
            SceneManager.LoadScene(0);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
          vida -= 10;

          //  Destroy(collision.gameObject);
        }
    }
}
