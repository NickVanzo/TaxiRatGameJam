using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public GameObject backToMainMenu;
    public GameObject player;

    public float remainingTime;
    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime <= 0)
        {
            player.GetComponent<PlayerMovement>().playerVelocity = 0;
            Cursor.visible = true;
            backToMainMenu.SetActive(true);
        }

    }
}
