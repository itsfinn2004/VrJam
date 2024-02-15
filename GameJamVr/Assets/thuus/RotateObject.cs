using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeed = 50f;
    public bool x;
    public bool y;
    public bool z;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (y)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        else if (z) 
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else if(x)
        {
           transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
    }
}
