using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject screenManager;

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Open(string screen)
    {
        screenManager.BroadcastMessage("Open", screen);
    }
}
