using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRottion : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        bool isRotatingLeft = Input.GetKey(KeyCode.A);
        bool isRotatingRight = Input.GetKey(KeyCode.D);
      
        if (isRotatingLeft)
        {
            // Rotate left
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        else if (isRotatingRight)
        {
            // Rotate right
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}