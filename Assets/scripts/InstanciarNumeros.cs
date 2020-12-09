using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstanciarNumeros : MonoBehaviour
{
    public GameObject[] numeros;//cargo todos los gameObject numeros
    private GameObject padre;

    [SerializeField] int CantX = 6;//cantidad de numeros en eje X
    [SerializeField] int CantY = 6;//cantidad de numeros en eje y
    [SerializeField] Vector2 posicionInicialNumeros = new Vector2(1.25f,1.25f);
    
    // Start is called before the first frame update
    void Start()
    {
        //padre = GameObject.FindGameObjectWithTag("MAT_MATIC_fondo");//busco el objeto que tiene etiqueta canvas importante para hacer hijos a los números instanciados
        padre = GameObject.FindGameObjectWithTag("canvas");//busco el objeto que tiene etiqueta canvas importante para hacer hijos a los números instanciados

        //Este es un doble bucle para posicionar en el eje Y y X
        for (int y = 0; y < CantX; y++)//repite seis veces en el eje Y
        {
            for (int x = 0; x < CantY; x++)//repite seis veces en el eje X
            {
                int indiceAleatorioDeNumeros = Random.Range(0,numeros.Length);//obtiene un indice aleatorio desde cero hasta la cantidad de objetos del arreglo de números
                //instancia el número de forma aleatoria en una posición
                GameObject numero = Instantiate(numeros[indiceAleatorioDeNumeros],new Vector3(0,0,0),Quaternion.identity);//Instancio el gameObject numero y lo guardo en una variable
                
                numero.gameObject.transform.SetParent(padre.gameObject.transform);//hago que todos los números sean hijos de canvas
                
                //Como son botones tengo que buscarcar el componente rectTransform y posicionarlos en su localPosicion
                numero.transform.localPosition= new Vector3
                    (
                        -100+(40*x),//acomoda en el eje X
                        60-(40*y),//Acomoda en el eje y
                        //  -posicionInicialNumeros.x + (0.5f * x),//acomoda en el eje X
                        //  posicionInicialNumeros.y - (0.5f * y),//Acomoda en el eje y
                        0
                    );
                numero.transform.localScale = new Vector3(1.2f,1.2f,0);//para que todos los botones tengan el mismo tamaño
               
                // numero.transform.localScale = new Vector3(1,1,0);//para que todos los botones tengan el mismo tamaño

                //print(numero.GetComponent<RectTransform>().localPosition);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
