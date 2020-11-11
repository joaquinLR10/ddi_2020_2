using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    public GameObject text;
    private Inventory inventory;

    void Start()
    {
       // inventory = FindObjectOfType<Inventory>();
       inventory = Inventory.InventoryInstance;
        if (inventory == null)
        {
            return;
        }
        inventoryUIPanel.SetActive(false);
        text.SetActive(false);
        inventory.onChange += UpdateUI;
    }

    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            inventoryUIPanel.SetActive(!inventoryUIPanel.activeSelf);
             text.SetActive(!text.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        for (int i = 0; i<slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].SetItem(inventory.items[i]);
            }
            else
            {
                slots[i].Clear();
            }
        }
    }
}

 
