using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoatColliderHandler : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    public GameObject backToMainMenu;
    public GameObject player;
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
            player.GetComponent<PlayerMovement>().playerVelocity = 0;
            Cursor.visible = true;
            backToMainMenu.SetActive(true);
        }
        if (other.gameObject.CompareTag("Cheese"))
        {
            Debug.Log("CheeseGot");
            gm.CheeseGet();
        }
    }
}
