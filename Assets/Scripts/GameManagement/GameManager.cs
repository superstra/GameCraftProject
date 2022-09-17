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

    public void StartGame ()
    {
        SceneManager.LoadScene(startScreenName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
