using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCameraScript : MonoBehaviour
{
    [SerializeField] private GameObject followTarget;

    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = followTarget.transform.position;
    }
}
