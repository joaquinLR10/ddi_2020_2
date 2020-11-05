using System.Collections;
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
        if(item.itemType==ItemType.Food)
        {
              
      
              Debug.Log("cogiendo jamon....");
        }
        else
        {
        Debug.Log("cogiendo posion......");
         
        }
      
        inventory.Add(item);
        Destroy(gameObject);
    }
}