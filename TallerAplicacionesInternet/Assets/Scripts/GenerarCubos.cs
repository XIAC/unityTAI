using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarCubos : MonoBehaviour
{
    public GameObject cubos;
    public float frecuencia = 0.5f;
    // private float siguiente = 0.0f;
    void Start()
    {
        StartCoroutine(LanzarCubo());
    }   
    IEnumerator LanzarCubo(){
        yield return new WaitForSeconds(2.0f);
        
        while(true){
            Instantiate(cubos, transform.position, Random.rotation);
            yield return null;//retorno parcial 
            yield return new WaitForSeconds(frecuencia);
        }
    }
    // Update is called once per frame
    void Update()
    {
    //    if (Time.time > siguiente){
    //         siguiente = Time.time + frecuencia;
    //         Instantiate(cubos, transform.position, Random.rotation);
    //    } 
    }
}
