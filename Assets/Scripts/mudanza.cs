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
    int minimoKilos = 100;
    float horaCamion = 3000;
    float horaPickup = 4500;
    float horaUtilitario = 7000;
    int precioTotal;
    

    // Start is called before the first frame update
    void Start()
    {
        if(cuantosKilosALLevar < minimoKilos)
        {
            Debug.Log("La cantidad minima de kilos a llevar es " + minimoKilos);
            return;
        } else if(kilometros <= cantidadMinimaDeKilometros)
            
        {
            
        }
        
        
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
