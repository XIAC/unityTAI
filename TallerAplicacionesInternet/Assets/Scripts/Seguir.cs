using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    public GameObject balon;
    private Vector3 desplazamiento;
    // Start is called before the first frame update
    void Start()
    {
        desplazamiento = transform.position -  balon.transform.position;
    }

    void LateUpdate()
    {
        transform.position = balon.transform.position + desplazamiento;
    }
}
