using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs;


public class TimeSwitch : MonoBehaviour
{
    public bool Future;
    public GameObject player;
    public GameObject past;
    public GameObject future;
    [SerializeField]
    InputActionProperty m_ActivateAction = new InputActionProperty(new InputAction("Activate", type: InputActionType.Button));
    public InputActionProperty activateAction
    {
        get => m_ActivateAction;
        set
        {
            ChangeTime();
        }
    }
    public void ChangeTime()
    {
        print("action");
        if (Future)
        {
            player.transform.position = future.transform.position;
            Debug.Log("past");
            Future = !Future;
        }
        else
        {
            player.transform .position = past.transform.position;
            Debug.Log("future");
            Future = !Future;
        }

    }
    void SetInputActionProperty(ref InputActionProperty property, InputActionProperty value)
    {
        if (Application.isPlaying)
            property.DisableDirectAction();

        property = value;

        if (Application.isPlaying && isActiveAndEnabled)
            property.EnableDirectAction();
    }
}
