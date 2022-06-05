using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class GameManager : MonoBehaviour
{
   public static GameManager instance;
   
    public int scorep;
    public Text scoretext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = scorep.ToString();
    }
}
