using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/InventoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
    public string id;
    public Sprite icon;
}
