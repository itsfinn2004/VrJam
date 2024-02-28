using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerSet : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float timer;

    private void Awake()
    {
        timer = PlayerPrefs.GetFloat("Time");

        text.text = $"Your Time = {timer} ";
    }
}
