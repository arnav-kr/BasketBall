using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text scoreCount;

    public GameObject screenManager;

    public void Setup(int score)
    {
        Time.timeScale = 0f;
        scoreCount.text = "Score: " + score;
        screenManager.BroadcastMessage("Open", "GameOver");
    }
}
