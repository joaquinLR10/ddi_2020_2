using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "nueva comida", menuName = "Inventario/Food/Ham")]
public class Ham : Item
{
   
   public override void Use()
   {
       Debug.Log("comiendo....");
   }
}
