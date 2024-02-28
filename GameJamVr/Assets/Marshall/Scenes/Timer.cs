using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;

    public void FixedUpdate()
    {
        timer += Time.deltaTime;
        PlayerPrefs.SetFloat("Time", timer);
    }
}
