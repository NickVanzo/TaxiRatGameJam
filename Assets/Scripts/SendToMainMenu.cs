using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendToMainMenu : MonoBehaviour
{
    public void SendToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
