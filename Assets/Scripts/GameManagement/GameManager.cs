using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public void Start()
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
        Debug.Log("START!");
    }
    public void ExitGame()
    {
        Debug.Log("EXIT...");
    }
}
