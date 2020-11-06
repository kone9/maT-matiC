using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public int cronometro = 30;//Tiempo que se usara para el cronometro
    private Text tiempo;//VAriable para obtener el text que se ve en pantalla

     private ManejadorJuego manejadorjuego;//referencia al manejador juego
    // Start is called before the first frame update
    void Start()
    {
        manejadorjuego = FindObjectOfType<ManejadorJuego>();
        tiempo = GetComponent<Text>();//obntengo el componente
        StartCoroutine("CuentaRegresiva");///llamo a la corrutina que hace la cuenta regresiva
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CuentaRegresiva()//corrutina que cuenta treinta segundos
    {
        for (int i = 0; i < 30; i++) //El cronometro cuenta hasta treinta
        {
            yield return new WaitForSeconds(1f);//espero un segundo
            cronometro -= 1;//descuento un valor al numero de cronometro
            tiempo.text = Convert.ToString(cronometro);//uso el valor del número que es un int en el texto..convierto a String
        }
        manejadorjuego.gameOver = true;    
        
    }
}
