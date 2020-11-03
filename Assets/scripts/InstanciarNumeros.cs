using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarNumeros : MonoBehaviour
{
    public GameObject[] numeros;//cargo todos los gameObject numeros

    // Start is called before the first frame update
    void Start()
    {
        //este es un doble bucle para posicionar en el eje Y y X
        for (int y = 0; y < 6; y++)//repite seis veces en el eje Y
        {
            for (int x = 0; x < 6; x++)//repite seis veces en el eje X
            {
                int indiceAleatorioDeNumeros = Random.Range(0,numeros.Length);//obtiene un indice aleatorio desde cero hasta la cantidad de objetos del arreglo de números
                //instancia el número de forma aleatoria en una posición
                GameObject numero = Instantiate(numeros[indiceAleatorioDeNumeros],new Vector3
                        (
                            (1.25f+(-0.5f*x)),//acomoda en el eje X
                            (1.25f+(-0.5f*y)),//Acomoda en el eje y
                            0
                        ),
                        Quaternion.identity
                    );//la posicion donde se instanciara
                
                numero.transform.parent = this.gameObject.transform;//los numeros se instancian como hijos del Gameobjet que posee este script (G)
                print(indiceAleatorioDeNumeros);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
