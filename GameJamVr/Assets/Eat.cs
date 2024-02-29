using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.ParticleSystemJobs;

public class Eat : MonoBehaviour
{
    public AudioSource eat;
    public ParticleSystem eatParticle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Eat")
        {
            if (eat != null)
            { 
                eat.Play();
                eatParticle.Play();
            }
                Object.Destroy(other.gameObject);


        }
        if (other.gameObject.tag == "Objective")
        {
            if (eat != null)
            {
                eat.Play();
                eatParticle.Play();
            }
            other.transform.position = new Vector3(100, 20, 100);
        }
    }
}
