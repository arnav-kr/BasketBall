using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject GameOver;

    public GameObject About;

    public GameObject MainMenu;

    public void Open(string screen)
    {
        if (screen == "Game")
        {
            GameOver.SetActive(false);
            About.SetActive(false);
            MainMenu.SetActive(false);
        }
        else if (screen == "GameOver")
        {
            GameOver.SetActive(true);
            About.SetActive(false);
            MainMenu.SetActive(false);
        }
        else if (screen == "About")
        {
            GameOver.SetActive(false);
            About.SetActive(true);
            MainMenu.SetActive(false);
        }
        else if (screen == "MainMenu")
        {
            GameOver.SetActive(false);
            About.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
}
