using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class life : MonoBehaviour
{
    public float vidaP = 100;
    public Slider sliderVida;
    public GameObject FVX;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sliderVida.value = vidaP;

        if (vidaP == 0)
        {
            Instantiate(FVX,gameObject.transform);
            Destroy(gameObject,2F);
            SceneManager.LoadScene(0);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nave"))
        {
           // vidaP -= 10;
         //   Debug.Log("aa");
            //  Destroy(collision.gameObject);
        }
    }
}
