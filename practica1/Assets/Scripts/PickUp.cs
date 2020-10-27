﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    private Inventory inventory;
    public Item item;
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            Debug.LogWarning("No se encontró el inventario");
        }
    }

    public override void Interact()
    {
        Debug.Log("Levantando item");
        if (item.itemType != ItemType.Money)
        {
            inventory.Add(item);
        }
        else
        {
            Debug.Log("Sumando monedas");
        }
        Destroy(gameObject);
    }
}