using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numeros : MonoBehaviour
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
        
    }


    //Estos métodos son llamados desde los botones dependiendo cual se presione
    //se suma/resta/multiplica/divide el resultado,esto esta medio desprolijo,luego
    //tengo que mejorar el código sin embargo asi se entiende el problema
    public void Uno()
    {
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 1;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 1;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 1;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 1;
        }
    }
    public void Dos()
    {
        
        print("presione dos");
        print(manejadorjuego.OperacionARealizar);
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
            print(manejadorjuego.calcularResultado);
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
            
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Tres()
    {
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Cuatro()
    {
         if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Cinco()
    {
         if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Seis()
    {
         if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Siete()
    {
          if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Ocho()
    {
         if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
    public void Nueve()
    {
         if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado *= 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado /= 2;
        }
    }
}
