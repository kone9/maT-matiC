using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularResultado : MonoBehaviour
{
    private ManejadorJuego manejadorjuego;
    // Start is called before the first frame update
    void Start()
    {
        manejadorjuego = FindObjectOfType<ManejadorJuego>();//busca un objeto de tipo manejador juego en todo el juego

    }

    // Update is called once per frame
    void Update()
    {
        if(manejadorjuego.gameOver == false)
        {
            print(manejadorjuego.calcularResultado);
        }

    }
}
