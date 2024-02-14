using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
     
    public Vector3 spawn;
    public Quaternion transrotation;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;

        transrotation = transform.rotation;



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "outOfBounds")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            this.transform.position = spawn;
            this.transform.rotation = transrotation;
            

        }
    }
}
