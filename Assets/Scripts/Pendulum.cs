using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed;
    public float limit = 75f;
    private float random = 0;
    
     void Awake()
    {
         random = Random.Range(0, 1f * 100);
         speed = Random.Range(1, 5);
    }
    // Update is called once per frame
    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time + random * speed);
        this.transform.localRotation = Quaternion.Euler(0,0,angle);
    }
}
