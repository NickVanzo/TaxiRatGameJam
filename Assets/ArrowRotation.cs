using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject arrival = GameObject.Find("Arrival (1)(Clone)");
        if (arrival)
        {
            Vector3 direction = arrival.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction, Vector3.up);    
        }
        
    }
}
