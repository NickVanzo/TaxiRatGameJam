using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] customerSpawnPoints;
    public Transform[] arrivals;
    public GameObject arrivalPrefab;
    public Transform currentArrival;
    public Customer customerPrefab;
    public Customer currentCustomer;
    public Transform arrival;
    public int money = 0;
    public TextMeshProUGUI cheese;
    public Canvas canvas;
    public GameObject player;
    
    void Start()
    {
        InstantiateCustomer();
    }

    public void AssignCustomer()
    {
        InstantiateRandomArrival();
        Destroy(GameObject.Find("Customer(Clone)"));
    }

    public void ArrivalReached()
    {
        Destroy(GameObject.Find("Arrival (1)(Clone)"));
        InstantiateCustomer();
        money += 30;
        canvas.GetComponent<Timer>().remainingTime += 15;
        cheese.text = "" + money;
    }

    public void CheeseGet()
    {
        Destroy(GameObject.Find("Cheese Variant"));
        player.GetComponent<PlayerMovement>().playerVelocity = 25;
        StartCoroutine(SpeedBoostDuration());
    }


    void InstantiateCustomer()
    {
        Instantiate(
            customerPrefab,
            customerSpawnPoints[Random.Range(0, customerSpawnPoints.Length)].transform.position,
            Quaternion.identity
        ); 
    }

    void InstantiateRandomArrival()
    {
        Instantiate(
            arrivalPrefab,
            arrivals[Random.Range(0, arrivals.Length)].transform.position,
            Quaternion.identity
        );
    }

    IEnumerator SpeedBoostDuration()
    {
        yield return new WaitForSeconds(5);
        player.GetComponent<PlayerMovement>().playerVelocity = 10;

    }
}
