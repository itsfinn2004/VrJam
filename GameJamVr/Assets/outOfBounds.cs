using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    
     
    public Vector3 spawn;
    

    private void Awake()
    {
        spawn = transform.position;



    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "outOfBounds")
        {
            
        }
    }
}
