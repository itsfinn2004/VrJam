using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PuzzleManager : MonoBehaviour
{
    public int CorrectCandles;

    public GameObject[] Keys;

    public Transform BlueKeySpawn;
    public bool FinalKey = true;

    private void FixedUpdate()
    {
        if (CorrectCandles == 10 && FinalKey)
        {
            SpawnKeyBlue();
            FinalKey = false;
        }
    }

    public void SpawnKeyBlue()
    {
        Instantiate(Keys[0], new Vector3(BlueKeySpawn.position.x, BlueKeySpawn.position.y,
            BlueKeySpawn.position.z), new Quaternion(0,0,0,0));
    }

}
