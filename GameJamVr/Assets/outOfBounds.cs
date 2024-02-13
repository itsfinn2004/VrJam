using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
     
    public Vector3 spawn;
    public Quaternion transrotation;
    

    private void Awake()
    {
        spawn = transform.position;

        transrotation = transform.rotation;



    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "outOfBounds")
        {
            gameObject.transform.position = spawn;
            gameObject.transform.rotation = transrotation;

        }
    }
}
