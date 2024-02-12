using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Deur : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject sleutelGat;
    private bool locked = true;

    public float rotationSpeed = 90f;
    public Quaternion beginRotation;
    public Quaternion targetRotation;
    private float elapsedTime = 0f;

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
            elapsedTime += Time.deltaTime;

            Quaternion newRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            transform.rotation = newRotation;
        }
    }
}
