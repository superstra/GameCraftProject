using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] GameObject itemPrefab;

    private GridLayout gridLayout;

    private void Start()
    {
        RenderInventory();
    }

    private void OnEnable()
    {
        InventoryManager.OnModifyInventory += RenderInventory;
    }

    private void OnDisable()
    {
        InventoryManager.OnModifyInventory -= RenderInventory;
    }

    private void RenderInventory ()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        foreach (InventoryItem item in InventoryManager.instance.GetItems())
        {
            GameObject g = Instantiate(itemPrefab, transform);
            g.transform.localScale = Vector3.one;
            Image img = g.GetComponent<Image>();
            img.sprite = item.icon;
        }
    }
}
