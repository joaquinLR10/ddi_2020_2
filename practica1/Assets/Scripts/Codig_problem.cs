using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codig_problem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
 int i,j,cont=0;
        int[] nums={8,1,2,2,3};
       int[] nums2= new int[5];
        
       for(i=0;i<5;i++){
           cont=0;
           for(j=0;j<5;j++){
                if(nums[i]>nums[j]){
                    cont++;
                }
           }
           nums2[i]=cont;
           Debug.Log("output:"+ nums2[i]);
           
           
       }
     
    }
    
    
    
}

  