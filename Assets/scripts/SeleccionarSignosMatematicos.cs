using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeleccionarSignosMatematicos : MonoBehaviour
{
    
    public Button[] signosMatematicos;//arreglo de signos matematicos 0=suma 1=resta 2=multiplicacion 3= division
    
    
    //NOTA:En el proyecto desarrollado se usaron Signos combinados.
    public enum estadoOperacionSeleccionada//para saber en que estado se encuentra, activar botones y seleccionar la operación matemática
    {
        SUMA,
        RESTA,
        MULTIPLICACION,
        DIVISION,

    }

    private ManejadorJuego manejadorJuego;

    void Start()
    {
        manejadorJuego = FindObjectOfType<ManejadorJuego>();
        SeleccionarSigno(estadoOperacionSeleccionada.MULTIPLICACION);//De prueba inicio con multiplicación
        //IniciarSignoFormaAleatoria();//Para iniciar los signos de forma aleatoria
    }


    private void IniciarSignoFormaAleatoria()//para iniciar eleguir el signo de forma aleatoria
    {
        int numeroAleatorio = Random.Range(0,3);//el numero aleatorio depende de la cantidad de signos comienza desde cero
        if(numeroAleatorio == 0)//si es cero
        {
            SeleccionarSigno(estadoOperacionSeleccionada.SUMA);//suma
        }
        if(numeroAleatorio == 1)//si es uno
        {
            SeleccionarSigno(estadoOperacionSeleccionada.RESTA);//resta
        }
        if(numeroAleatorio == 2)//si es dos
        {
            SeleccionarSigno(estadoOperacionSeleccionada.MULTIPLICACION);//multiplicacion
        }
        if(numeroAleatorio == 3)//si es tres
        {   
            SeleccionarSigno(estadoOperacionSeleccionada.DIVISION);//division
        }
    }



    private void SeleccionarSigno(estadoOperacionSeleccionada estado)//dependiendo el estado activo boton
    {
        switch (estado)
        {
            case estadoOperacionSeleccionada.SUMA:
                signosMatematicos[0].Select();
                signosMatematicos[0].interactable = false;//el boton no interactua se queda presiona
                manejadorJuego.OperacionARealizar = operacionMatematica.SUMA;
                return;
            
            case estadoOperacionSeleccionada.RESTA:
                signosMatematicos[1].Select();
                signosMatematicos[1].interactable = false;//el boton no interactua se queda presiona
                manejadorJuego.OperacionARealizar = operacionMatematica.RESTA;
                return;
            
            case estadoOperacionSeleccionada.MULTIPLICACION:
                signosMatematicos[2].Select();
                signosMatematicos[2].interactable = false;//el boton no interactua se queda presiona
                manejadorJuego.OperacionARealizar = operacionMatematica.MULTIPLIACION;
                return;
            
            case estadoOperacionSeleccionada.DIVISION:
                signosMatematicos[3].Select();
                signosMatematicos[3].interactable = false;//el boton no interactua se queda presiona
                manejadorJuego.OperacionARealizar = operacionMatematica.DIVISION;
                return;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
