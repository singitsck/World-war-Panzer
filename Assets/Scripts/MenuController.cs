using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject Bar;
    public GameObject Map;
    public GameObject StartButton;
    public GameObject HowToPlay;
    public GameObject HowToPlayButton;
    public GameObject QuitButton;
    public GameObject Player;

    public void StartGame()
    {
        GameObject.Find("GameName").SetActive(false);
        Bar.SetActive(true);
        Map.SetActive(true);
        StartButton.SetActive(false);
        HowToPlayButton.SetActive(false);
        QuitButton.SetActive(false);
        Player.GetComponent<PlayerController>().enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HowToPlayB()
    {
        HowToPlay.SetActive(true);
    }

    public void Quit()
    {
        HowToPlay.SetActive(false);
    }
}
