using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Deur : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject sleutelGat;
    private bool locked = true;

    Quaternion beginRotation = new Quaternion(90,90,90,0);
    public string nextScene;

    private void OnTriggerEnter(Collider other)
    {
        print("Collison");
        if (other.gameObject.tag == "Sleutel")
        {
            print("Is Key");
            key = other.gameObject;
            other.GetComponent<XRGrabInteractable>().enabled = false;
            key.transform.position = sleutelGat.transform.position;
            key.transform.rotation = beginRotation;
            locked = false;
        }
    }

    private void FixedUpdate()
    {
        if (!locked)
        { 
            SceneManager.LoadScene(nextScene);
        }
    }
}
