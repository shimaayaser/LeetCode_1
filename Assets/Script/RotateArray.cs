using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArray {

         public void Rotate(int[] nums, int k) {
        int number = nums.Length;
        k = k % number;
        int[] result = new int[number];
        for (int i = 0; i < number; i++) {
            result[(i + k) % number] = nums[i];
        }
        for (int i = 0; i < number; i++) {
            nums[i] = result[i];
        }
    }


 
}
