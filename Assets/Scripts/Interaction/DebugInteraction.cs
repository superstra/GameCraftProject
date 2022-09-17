using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInteraction : InteractableBase
{
    protected override void Action()
    {
        Debug.Log("DOING AN ACTION...");
    }
}
