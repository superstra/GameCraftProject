using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TitleButtons : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button exitButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame ()
    {
        GameManager.instance.StartGame();
    }
    private void ExitGame ()
    {
        GameManager.instance.ExitGame();
    }
}
