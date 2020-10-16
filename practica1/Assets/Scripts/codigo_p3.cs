using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigo_p3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int target=9;
        //int target=39;
       // int target=82;
        int [] nums ={2,7,11,15};
       // int [] nums ={2,9,14,20,19};
      // int [] nums ={2,9,14,20,19,8,14,80};

       int [] output = new int[2];
       suma( target, nums, output);
       Debug.Log("["+output[0]+","+output[1]+"]");

    }

    // Update is called once per frame
  public int[] suma(int target,int[] nums,int[] output)
  {
      int i,j;
      for(i=0;i<nums.Length;i++)
      {
        for(j=0;j<nums.Length;j++)
         if(nums[i]+nums[j]==target)
            {
               
              output[0]=i;
              output[1]=j;
              return output;
            }    
        
      }
      
      return output;
  }
}
