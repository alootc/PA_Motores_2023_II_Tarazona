using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    private float tiempoActual = 1f; 

   
    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.T))
        {
            tiempoActual = 0.5f; 
            Time.timeScale = tiempoActual;
        }

     
        if (Input.GetKeyDown(KeyCode.N))
        {
            tiempoActual = 1f; 
            Time.timeScale = tiempoActual;
        }

       
        if (Input.GetKeyDown(KeyCode.A))
        {
            tiempoActual = 2f; 
            Time.timeScale = tiempoActual;
        }

    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
