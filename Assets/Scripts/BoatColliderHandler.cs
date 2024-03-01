using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if(other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Ball hit");
            SceneManager.LoadScene("MainMenu");
        }
        if (other.gameObject.CompareTag("Cheese"))
        {
            Debug.Log("CheeseGot");
            gm.CheeseGet();
        }
    }
}
