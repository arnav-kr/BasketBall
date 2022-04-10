using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject screenManager;

    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        screenManager.BroadcastMessage("Open", "Game");
        Time.timeScale = 1f;
    }
}
