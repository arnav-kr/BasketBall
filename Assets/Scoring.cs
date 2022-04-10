using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public GameOverScreen GameOverScreen;

    public TMP_Text scoreBox;

    public TMP_Text heartBar;

    private int score = 0;

    private int hearts = 10;

    void Start()
    {
        scoreBox.text = "Score: " + score;
        string text = "";
        for (int x = 0; x < hearts; x++)
        {
            text += "<sprite=0> ";
        }
        heartBar.text = text;
    }

    public void update_score(int amount)
    {
        score += amount;
        scoreBox.text = "Score: " + score;
    }

    public void heart(int amount)
    {
        hearts -= amount;
        if (hearts <= 0)
        {
            GameOver();
            score = 0;
            hearts = 10;
        }
        string text = "";
        for (int x = 0; x < hearts; x++)
        {
            text += "<sprite=0> ";
        }
        heartBar.text = text;
    }

    public void GameOver()
    {
        GameOverScreen.Setup (score);
    }
}
