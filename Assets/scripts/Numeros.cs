using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    private ManejadorJuego manejadorjuego;
    [SerializeField]private float tiempoAntesDeDesaparecerFicha = 1.0f;
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
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
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
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 1;
            
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 1;
            
        }
        
    }

    public void Dos()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
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
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 2;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 2;
        }
        
    }

    public void Tres()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 3;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 3;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 3;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 3;
        }
        
    }
    public void Cuatro()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 4;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 4;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 4;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 4;
        }
        
    }
    public void Cinco()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 5;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 5;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 5;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 5;
        }
        
    }
    public void Seis()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 6;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 6;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 6;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 6;
        }
        
    }
    public void Siete()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 7;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 7;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 7;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 7;
        }
        
    }
    public void Ocho()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 8;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 8;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 8;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 8;
        }
        
    }
    public void Nueve()
    {
        this.gameObject.GetComponent<Button>().interactable = false;//hace que el boton ya no pueda volver a ser presionado
        if(manejadorjuego.OperacionARealizar == operacionMatematica.SUMA)
        {
            manejadorjuego.calcularResultado += 9;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.RESTA)
        {
            manejadorjuego.calcularResultado -= 9;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.MULTIPLIACION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado * 9;
        }
        if(manejadorjuego.OperacionARealizar == operacionMatematica.DIVISION)
        {
            manejadorjuego.calcularResultado = manejadorjuego.calcularResultado / 9;
        }
        
    }

    IEnumerator DestruirGameObject()
    {
        yield return new WaitForSeconds(tiempoAntesDeDesaparecerFicha);
        Destroy(this.gameObject);
    }
}
