using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int lives = 5, damage = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Texto(); 

    }

    void Texto()
    {
        Debug.Log(lives);
        lives = lives - damage;
        Debug.Log(lives);

      
    }





}

