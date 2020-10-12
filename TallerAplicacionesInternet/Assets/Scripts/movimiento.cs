using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // public float velocidad; 
    public float fuerzaValor;
    public float valorSalto;
    private Rigidbody rigidBody;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rigidBody.velocity.y);
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.01f){
                 Debug.Log("jump");
            rigidBody.AddForce(Vector3.up * valorSalto, ForceMode.Impulse);
            audio.Play();
        }
        // recibe de parametro 3 ejes
                            // x    y   z     1    -1
        // transform.Translate( Input.GetAxis("Horizontal") * velocidad * Time.deltaTime ,
        //                      0 , 
        //                      Input.GetAxis("Vertical") * velocidad *Time.deltaTime );
    }
    void FixedUpdate() {
        // crear un objeto dentro de Add Force
        rigidBody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * fuerzaValor));
    }
}
