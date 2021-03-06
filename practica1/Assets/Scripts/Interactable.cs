﻿

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable : MonoBehaviour
{
    bool isInsideZone = false;

    public virtual void Interact()
    {
        Debug.Log("Ejecutando interacción...");
    }

    void Update()
    {
       // Input.GetKeyDown(KeyCode.I)
        if(isInsideZone && CrossPlatformInputManager.GetButtonDown("Fire1"))
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
