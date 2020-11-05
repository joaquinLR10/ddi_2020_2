using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equip,
    Medicine,
    Money
}

[CreateAssetMenu(fileName = "Nuevo Item", menuName = "Inventario/Generic Item")]
public class Item : ScriptableObject
{
  
    public Sprite icon = null;
    public ItemType itemType = ItemType.Food;

    public virtual void Use()
    {
    
        Debug.Log("Usando item: " + name);
    }
}