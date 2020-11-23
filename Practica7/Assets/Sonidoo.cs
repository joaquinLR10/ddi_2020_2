using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sonidoo : MonoBehaviour
{
   public AudioClip sonido = null;
   public float volumen = 1.0f;//indica el volumen del sonido 
   protected Transform posicion = null;
   
   
    void Start()
    {
        posicion= transform;
    }

   

    void update(){
        if(CompareTag("Respawn"))
     if(sonido)
       {
           AudioSource.PlayClipAtPoint(sonido,posicion.position,volumen);
       }
       
    
      
       
        
    }
}