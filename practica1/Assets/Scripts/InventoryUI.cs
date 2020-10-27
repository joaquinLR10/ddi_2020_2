﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUIPanel;
    private Inventory inventory;

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            return;
        }
        inventoryUIPanel.SetActive(false);
        inventory.onChange += UpdateUI;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            inventoryUIPanel.SetActive(!inventoryUIPanel.activeSelf);
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
//public GameObject text;
 //text.SetActive(false);
 //text.SetActive(!text.activeSelf);