using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectSnap : MonoBehaviour
{
    public string tag;
    public GameObject snapObject;
    public PuzzleManager manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        snapObject = other.gameObject;
        if (snapObject != null)
        {
            if (snapObject.tag == tag)
            {
                snapObject.GetComponent<XRGrabInteractable>().enabled = false;
                snapObject.GetComponent<Rigidbody>().isKinematic = true;
                snapObject.transform.position = gameObject.transform.position;
                snapObject.transform.rotation= new Quaternion(0,0,0,0);
                manager.CorrectCandles++;
            }
        }
    }

   
}
