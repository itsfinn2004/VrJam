using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class pausemenu : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool paused;
    private void Update()
    {

        
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        foreach (var device in devices)
        {
            bool triggerValue;
            if (device.TryGetFeatureValue(CommonUsages.menuButton, out triggerValue) && triggerValue)
            {
                Debug.Log("Trigger button is pressed.");
                PauseMenu.SetActive(true);
                paused = true;

                                
            }
            else if(device.TryGetFeatureValue(CommonUsages.menuButton, out triggerValue) && triggerValue && paused == true)
            {
                PauseMenu.SetActive(false);
            }
        }
    }
}
