using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    [SerializeField] private string startScreenName;

    public void Awake()
    {
        // Singleton Pattern
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void OnEnable()
    {
        Timer.OnTimerEnd += StartGame;
    }

    private void OnDisable()
    {
        Timer.OnTimerEnd -= StartGame;
    }

    public void StartGame ()
    {
        AudioManager.instance.Play("RTC");
        LoadLevel(name);
    }

    private void Update()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadLevel (string name)
    {
        SceneManager.LoadScene(startScreenName);
    }
}
