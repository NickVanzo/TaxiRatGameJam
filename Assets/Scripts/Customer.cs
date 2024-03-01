using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public Vector3 destination = Vector3.zero;
    public int cheeseReward = 10;
    public int timeIncreaseInSeconds = 30;
    public int rotationSpeed = 10;
        
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);   
    }
}
