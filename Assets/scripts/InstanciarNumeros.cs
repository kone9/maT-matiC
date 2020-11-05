using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciarNumeros : MonoBehaviour
{
    public GameObject[] numeros;//cargo todos los gameObject numeros
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas");//busco el objeto que tiene etiqueta canvas importante para hacer hijos a los números instanciados

        //Este es un doble bucle para posicionar en el eje Y y X
        for (int y = 0; y < 6; y++)//repite seis veces en el eje Y
        {
            for (int x = 0; x < 6; x++)//repite seis veces en el eje X
            {
                int indiceAleatorioDeNumeros = Random.Range(0,numeros.Length);//obtiene un indice aleatorio desde cero hasta la cantidad de objetos del arreglo de números
                //instancia el número de forma aleatoria en una posición
                GameObject numero = Instantiate(numeros[indiceAleatorioDeNumeros],new Vector3(0,0,0),Quaternion.identity);//Instancio el gameObject numero y lo guardo en una variable
                
                numero.gameObject.transform.SetParent(canvas.gameObject.transform);//hago que todos los números sean hijos de canvas
                
                //Como son botones tengo que buscarcar el componente rectTransform y posicionarlos en su localPosicion
                numero.GetComponent<RectTransform>().localPosition= new Vector3
                    (
                        -100+(40*x),//acomoda en el eje X
                        60-(40*y),//Acomoda en el eje y
                        0
                    );
                numero.GetComponent<RectTransform>().localScale = new Vector3(1.2f,1.2f,0);//para que todos los botones tengan el mismo tamaño
                
                print(numero.GetComponent<RectTransform>().localPosition);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
