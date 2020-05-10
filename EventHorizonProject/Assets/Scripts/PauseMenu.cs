using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string mainMenuName;

    private void OnEnable()
    {
        Time.timeScale = 0;
        DisableInput();
    }

    private void DisableInput()
    {
        Debug.Log("ADD DISABLE FUNCTIONALITY");
    }

    private void EnableInput()
    {
        Debug.Log("ADD ENABLE FUNCTIONALITY");
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        EnableInput();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuName);
        Time.timeScale = 0f;
    }
}

