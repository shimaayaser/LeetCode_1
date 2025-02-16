using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MajorityElement 
{

    public class Solution {
    public int MajorityElement(int[] nums) {
       int count=0; 
       int ? number =null;
       foreach(int num in nums){
        if(count==0){
            number=num;
        }
        count+=(number==num)? 1:-1;
       }
        return number.Value;
    }
}
}
