using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGames()
    {
        SceneManager.LoadScene("Game");
    }

    public void Author()
    {
        Debug.Log("Created By Harist Setya Nugraha");
    }

    public void MainKeMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void KeCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
