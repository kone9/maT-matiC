using System;
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

//Si el tipo casilla esta vacio o ocupado
public enum TipoCasilla
{
    VACIO,
    OCUPADO
}


public class ManejadorJuego : MonoBehaviour
{

    public TipoCasilla[,] grilla;//array bidimensional referencia a las posiciones de es de tipo casilla para establecer si esta ocupado o vacio
    
    public int calcularResultado = 1;//Este sera el resultado que determinara si ganas o no
    public operacionMatematica OperacionARealizar;//para determinar en varios lados si tengo que sumar/restar/dividir/multiplicar
    public bool gameOver = false;//si es game over o no,esto lo determina el timer



    /// <summary>Obtiene una posición en la grilla en base a la posición de un objeto.</summary>
    /// <param name="posicion">Ingresar la posición donde se encuentra el objeto</param>
    /// <returns>un Arreglo que representa X/Y de la grilla de ese objeto.</returns>
    public TipoCasilla ObtenerGrilla(Vector3Int posicion)
    {
        return grilla[posicion.x,posicion.y];
    }


    /// <summary>Para establecer posiciónes de la grilla "vacia o ocupada".</summary>
    /// <param name="posicion">Posicion del objeto en la grilla</param>
    /// <param name="valor">Si esta vacio o ocupado</param>
    public void EstablecerGrilla(Vector3Int posicion,TipoCasilla valor)//Si en esta posición esta vacio o ocupado
    {
        grilla[posicion.x,posicion.y] = valor; //establece si en esa posición esta vacio o ocupado
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

  
}
