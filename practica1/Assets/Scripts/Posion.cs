using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nueva posion", menuName = "Inventario/Medicine/cura")]
public class Posion : Item
{
   
   public override void Use()
   {
       Debug.Log("curando....");
   }
}
