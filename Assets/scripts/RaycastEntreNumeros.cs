using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastEntreNumeros : MonoBehaviour
{
    //Ray BotonRaycast;
    RaycastHit2D hit2D;
    Vector3 posicion;
    [SerializeField] int lenghtRay = 100; //tamaño del rayo
    // Start is called before the first frame update
    
    private void Awake() {
       
    }
    void Start()
    {
        //print(posicion + (Vector3.down * 30));
        
        StartCoroutine("posicionNumeros");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(posicion,posicion + (Vector3.down * 30),Color.red,lenghtRay);
        //print("la posicion del boton es  " + this.name + posicion);
        Ray BotonRaycast = new Ray(posicion,Vector3.down);
        if(Physics.Raycast ( posicion,Vector3.down,30 ) )
        {
            print("el raycast colisiona");
        }   
    }

    IEnumerator posicionNumeros()
    {
        yield return new WaitForSeconds(2);
        posicion = this.transform.position;
        //print("NOMBRE:  "  + this.name +  " POSICIÓN: " + posicion);
    }
}
