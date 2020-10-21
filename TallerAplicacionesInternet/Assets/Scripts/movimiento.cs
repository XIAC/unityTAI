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
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBody.velocity.y) < 0.01f){
            rigidBody.AddForce(Vector3.up * valorSalto, ForceMode.Impulse);
            audio.Play();
        }
        if(Input.touchCount == 1){
            if (Input.touches[0].phase == TouchPhase.Began && Mathf.Abs(rigidBody.velocity.y) < 0.01f){
                rigidBody.AddForce(Vector3.up * valorSalto, ForceMode.Impulse);
                audio.Play();
            }
        }
    }
    void FixedUpdate() {
        // crear un objeto dentro de Add Force
        rigidBody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * fuerzaValor));
        // para el dispositivo movil
        rigidBody.AddForce(new Vector3(Input.acceleration.x, 0, Input.acceleration.y) * fuerzaValor);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Enmigo"){
            Destroy(collisionInfo.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entraste a la zona peligroso");
    }
}
