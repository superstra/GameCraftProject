using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] Button button;

    private void Start()
    {
        button.onMouseClick.AddListener(Action);

    }

    private void Action()
    {
        
    }
}