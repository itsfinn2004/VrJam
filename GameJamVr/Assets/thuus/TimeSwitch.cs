using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TimeSwitch : MonoBehaviour
{
    public bool Future;
    public GameObject player;
    public GameObject past;
    public GameObject future;
    [SerializeField] InputActionReference TimeButton;


   private bool time
    {
        get => TimeButton;
        set
        {
            ChangeTime();
        }
    }

    public void ChangeTime()
    {
        if (Future)
        {
            player.transform.position = future.transform.position;
            Future = false;
            Debug.Log("past");
        }
        else
        {
            player.transform .position = past.transform.position;
            Future = true;
            Debug.Log("future");
        }

    }
}
