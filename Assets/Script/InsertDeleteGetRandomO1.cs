using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertDeleteGetRandomO1 
{
   public class RandomizedSet {
    private List<int> numbers;
    private Dictionary<int, int> index;
    private Random random;
    public RandomizedSet() {
        numbers = new List<int>();
        index = new Dictionary<int, int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
          if (index.ContainsKey(val)) {
            return false;
          }
          numbers.Add(val);
          index[val] = numbers.Count - 1;
          return true;
    }
    
    public bool Remove(int val) {
          if (!index.ContainsKey(val)) {
            return false;
        }

        int lastElement = numbers[numbers.Count - 1];
        int valueIndex = index[val];

        numbers[valueIndex] = lastElement;
        index[lastElement] = valueIndex;

        numbers.RemoveAt(numbers.Count - 1);
        index.Remove(val);

        return true;
    }
    
    public int GetRandom() {
        int randomIndex = random.Next(numbers.Count);
        return numbers[randomIndex];
    }
}

}
