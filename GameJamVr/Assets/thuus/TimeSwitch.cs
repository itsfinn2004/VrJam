using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    public bool Future;
    public GameObject futureObjects;
    public GameObject pastObjects;

    void Update()
    {
        
    }
    public void ChangeTime()
    {
        if (Future)
        {
            pastObjects.SetActive(false);
            futureObjects.SetActive(true);
            Debug.Log("past");
        }
        else
        {
            futureObjects.SetActive(false);
            pastObjects.SetActive(true);
            Debug.Log("future");
        }

    }
}
