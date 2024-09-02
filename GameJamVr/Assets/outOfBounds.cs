using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
     
    public Vector3 spawn;
    public Quaternion transrotation;
    public Rigidbody rb;
    public bool isPlayer;
    public MeshCollider mc;

    private void Awake()
    {
        mc.GetComponent<MeshCollider>();
        rb = GetComponent<Rigidbody>();
        spawn = transform.position;

        transrotation = transform.rotation;
        mc.enabled = false;
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "outOfBounds")
        {
            if(!isPlayer)
            {
                Debug.Log("test if not player");
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                this.transform.position = spawn;
                this.transform.rotation = transrotation;
            }
            else
            {
                Debug.Log("test if wel player");
                this.transform.position = spawn;
                this.transform.rotation = transrotation;
            }


        }
    }
}
    