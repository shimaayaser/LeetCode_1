using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target) {
        int []number= new int[2];
        for(int i=0;i<nums.Length;i++){
              for (int j =i+1; j < nums.Length; j++)/* or int j=1 */ {
                if (nums[i] + nums[j] == target) {
                    number[0] = i;
                    number[1] = j;
                    return number;
                }
            }
        }  
        return number;
    }
}
