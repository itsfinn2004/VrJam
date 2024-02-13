using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSwitch : MonoBehaviour
{
    public bool Future;
    public GameObject futureObjects;
    public GameObject pastObjects;

  
    public void ChangeTime()
    {
        if (Future)
        {
            pastObjects.SetActive(false);
            futureObjects.SetActive(true);
            Future = false;
            Debug.Log("past");
        }
        else
        {
            futureObjects.SetActive(false);
            pastObjects.SetActive(true);
            Future = true;
            Debug.Log("future");
        }

    }
}
