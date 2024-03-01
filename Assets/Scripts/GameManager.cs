using System.Collections;
using System.Collections.Generic;
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
}