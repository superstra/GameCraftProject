using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInteraction : BaseInteraction
{
    private enum InventoryModificationMode
    {
        Add,
        Remove
    }

    [SerializeField] private InventoryModificationMode mode;
    [SerializeField] private InventoryItem[] items;

    protected override void Action()
    {
        if (mode == InventoryModificationMode.Add)
        {
            foreach (InventoryItem item in items)
            {
                InventoryManager.instance.AddItem(item);
            }
        }
        else
        {
            foreach (InventoryItem item in items)
            {
                InventoryManager.instance.RemoveItem(item);
            }
        }
    }
}
