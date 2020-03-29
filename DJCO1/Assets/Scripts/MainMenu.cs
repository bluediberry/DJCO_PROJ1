﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void TimeOut()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void TimeOut2()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 3);
    }


    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}