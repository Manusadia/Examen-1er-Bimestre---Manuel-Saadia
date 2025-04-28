using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudanza : MonoBehaviour
{

    public int cuantosKilosALLevar;
    public int kilometros;
    int capacidadCamion = 10000;
    int capacidadPickup = 5000;
    int capacidadUtilitario = 2000;
    int cantidadMinimaDeKilometros = 50;
    float horaCamion = 3000;
    float horaPickup = 4500;
    float horaUtilitario = 7000;
    int precioTotal;
    

    // Start is called before the first frame update
    void Start()
    {
        if(cuantosKilosALLevar < 100 || cuantosKilosALLevar >10000)
        {
            Debug.Log("La cantidad de kilos a llevar no es valida" );
            return;
        } else if(cuantosKilosALLevar <= capacidadUtilitario)
        {
            precioTotal = kilometros 
        }
            
        {
            
        }
        
        
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
