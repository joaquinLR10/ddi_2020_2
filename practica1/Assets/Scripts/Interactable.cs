using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
   public AudioClip sonido = null;
   public float volumen = 1.0f;//indica el volumen del sonido 
   protected Transform posicion = null;
    void Start()
    {
        posicion= transform;
    }

   

    void OnTriggerEnter(Collider other)
    {
        
        if(!other.CompareTag("Player"))
        {
            return;
        }
       if(sonido)
       AudioSource.PlayClipAtPoint(sonido,posicion.position,volumen);

       
        
    }
}
