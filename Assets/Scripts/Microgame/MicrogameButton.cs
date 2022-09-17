using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MicrogameButton : MonoBehaviour
{
    [SerializeField] Button button;

    private void Start()
    {
        button.onClick.AddListener(Action);

    }

    private void Action()
    {
        
    }
}