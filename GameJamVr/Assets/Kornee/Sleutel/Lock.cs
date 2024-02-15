using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject sleutelGat;
    private bool locked = true;
    public int key_Id;
    public GameObject Spawn;

    Quaternion beginRotation = new Quaternion(90,90,90,0);
    public string nextScene;

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Sleutel")
        {
            
            key = other.gameObject;
            if(key.GetComponent<Key_ID>().key_Id == key_Id)
            {
                other.GetComponent<XRGrabInteractable>().enabled = false;
                key.transform.position = sleutelGat.transform.position;
                key.transform.rotation = beginRotation;
                locked = false;
                Object.Destroy(key);
            }
        }
    }

    private void FixedUpdate()
    {
        if (!locked)
        { 
            switch(key_Id)
            {
                case 0:
                    SceneManager.LoadScene(nextScene);
                    break;
                case 1:
                    Instantiate(Spawn, transform.position, Quaternion.identity);
                    Object.Destroy(gameObject);
                    break;
                case 5:
                    Instantiate(Spawn, transform.position, Quaternion.identity);
                    Object.Destroy(gameObject);
                    break;


            }
        }
    }
}
