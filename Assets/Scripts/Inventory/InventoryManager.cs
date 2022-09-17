using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public delegate void InventoryAction ();
    public static event InventoryAction OnModifyInventory;

    public static InventoryManager instance;

    private List<InventoryItem> items = new();

    void Awake()
    {
        Debug.Log("START");
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
        OnModifyInventory?.Invoke();
    }

    public bool CheckItem (InventoryItem item)
    {
        return items.Contains(item);
    }

    public void RemoveItem(InventoryItem item)
    {  
        items.Remove(item);
        OnModifyInventory?.Invoke();
    }

    public IEnumerable GetItems ()
    {
        return items.ToArray();
    }
}
