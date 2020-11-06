using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum operacionMatematica
{
    SUMA,
    RESTA,
    MULTIPLIACION,
    DIVISION
}

public class ManejadorJuego : MonoBehaviour
{
    


    public int calcularResultado = 1;//Este sera el resultado que determinara si ganas o no
    public operacionMatematica OperacionARealizar;//para determinar en varios lados si tengo que sumar/restar/dividir/multiplicar
    public bool gameOver = false;//si es game over o no,esto lo determina el timer

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
