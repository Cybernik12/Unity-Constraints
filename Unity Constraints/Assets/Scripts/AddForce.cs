using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigidbody = collision.rigidbody;

        rigidbody.AddForce(-transform.forward * 500);
        rigidbody.useGravity = true;
    }*/

    private void OnMouseDown()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();

        rigidbody.AddForce(-transform.forward * 500);
        rigidbody.useGravity = true;
    }

}
