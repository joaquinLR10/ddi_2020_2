using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigo_p2 : MonoBehaviour
{
    
    void Start()
    {
        
         string [] inscritos = {"alberto","carlos","daniel","joaquin","kennya","omar"};
         string nombre ="joaquin";
         comparacion(nombre,inscritos);
    }

        void comparacion(string nombre,string [] inscritos){
        int i,flag=0;
        for(i=0;i<inscritos.Length;i++)
            if(nombre.CompareTo(inscritos[i])==0){
               flag=1;
                Debug.Log("El alumno inscrito es :"+inscritos[i]);
                
            }
           if(flag!=1)
          Debug.Log("el alumno no esta inscrito");
          
         
    }
}





