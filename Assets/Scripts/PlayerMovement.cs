using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerVelocity = 5.0f;
    public float rotationSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        bool isMovingForward = Input.GetKey(KeyCode.W);
        bool isRotatingLeft = Input.GetKey(KeyCode.A);
        bool isRotatingRight = Input.GetKey(KeyCode.D);
        
        if (isMovingForward || true)
        {
            transform.Translate(Time.deltaTime * playerVelocity * Vector3.forward);
        }
        
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
