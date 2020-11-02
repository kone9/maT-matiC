using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarNumeros : MonoBehaviour
{
    public GameObject[] numeros;//cargo todos los gameObject numeros

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 1; x < 6; x++)
        {
            GameObject numero = Instantiate(numeros[0],new Vector3(x,0,0),Quaternion.identity);//la posicion donde se instanciara
            numero.transform.parent = this.gameObject.transform;//los numeros se instancian como hijos del Gameobjet que posee este script
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
