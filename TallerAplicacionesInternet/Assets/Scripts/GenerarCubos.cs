using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject cubos;
    public float frecuencia = 0.5f;
    private float siguiente = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > siguiente){
            siguiente = Time.time + frecuencia;
            Instantiate(cubos, transform.position, Random.rotation);
       } 
    }
}
