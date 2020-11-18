﻿

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;
   

    public virtual void Interact()
    {
        
        Debug.Log("Ejecutando interacción...");
      
        Destroy(gameObject);
    }

    void Update()
    {
       // Input.GetKeyDown(KeyCode.I)
        if(isInsideZone)
        {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }
}
