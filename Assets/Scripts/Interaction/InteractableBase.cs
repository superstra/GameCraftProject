using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableBase : MonoBehaviour
{
    private void OnEnable()
    {
        ClickableObject.OnLeftClick += HandleClick;
    }

    private void OnDisable()
    {
        ClickableObject.OnLeftClick -= HandleClick;
    }

    private void HandleClick(GameObject origin, Vector3 position)
    {
        if (origin == this.gameObject)
        {
            Action();
        }
    }

    protected abstract void Action();
}
