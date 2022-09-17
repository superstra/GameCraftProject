using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    private List<InventoryItem> items = new();

    void Start()
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

    public void AddItem (InventoryItem item)
    {
        items.Add(item);
    }

    public bool CheckItem (InventoryItem item)
    {
        return items.Contains(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        items.Remove(item);
    }
}
