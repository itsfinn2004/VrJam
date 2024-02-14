using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicobject = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicobject.Length > 1)
        {
            //Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
