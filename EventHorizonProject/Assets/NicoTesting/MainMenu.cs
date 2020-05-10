using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string GameSceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //SceneManager.LoadScene(GameSceneName);
        //Time.timeScale = 1f;
        Debug.Log("play game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("stopgame");
    }
}
