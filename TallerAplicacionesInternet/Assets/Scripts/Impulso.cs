using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    // Start is called before the first frame update
    public float fuerza =  8.0f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * fuerza, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0.0f){
            Destroy(gameObject);
        }
    }
}
