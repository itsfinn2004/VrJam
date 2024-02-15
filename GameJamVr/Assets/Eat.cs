using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Eat : MonoBehaviour
{
    public AudioSource eat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Eat")
        {
            if (eat != null)
            { 
                eat.Play();
            }
                Object.Destroy(other.gameObject);


        }
        if (other.gameObject.tag == "Objective")
        {
            if (eat != null)
            {
                eat.Play();
            }
            other.transform.position = new Vector3(100, 20, 100);
        }
    }
}
