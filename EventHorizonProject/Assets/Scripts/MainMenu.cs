﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string GameSceneName;

    public void StartGame()
    {
        SceneManager.LoadScene(GameSceneName);
        Time.timeScale = 1f;
        //Debug.Log("play game");
    }

    public void QuitGame()
    {
        Application.Quit();
        //Debug.Log("stopgame");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
