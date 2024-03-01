using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatColliderHandler : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("HITTING");
        if (other.gameObject.CompareTag("Customer"))
        {
            gm.AssignCustomer();
        }
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Arrivals"))
        {
            gm.ArrivalReached();
        }
    }
}
