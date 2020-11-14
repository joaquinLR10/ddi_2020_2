using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [] nums ={12,345,2,6,7896};
        string numString="";
        int pares=0;

        Debug.Log("output: "+ par(numString,nums,pares));
    }
    
    public int par(string numString,int[] nums,int pares)
    {
      int i,j,suma=0;
      for(i=0;i<nums.Length;i++)
      {
          numString= ""+nums[i];
       for(j=0;j<numString.Length;j++)
       {
           suma+=1;
       }
       if(suma%2==0)
       {
           pares+=1;
       }
        suma=0;
      }
     return pares;
    }
  
}
