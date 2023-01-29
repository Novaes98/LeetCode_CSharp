using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp.Problems
{
    public class Solution { 
    
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.ContainsValue(target - nums[i]))
                {
                    result[0] = i;
                    result[1] = hash.FirstOrDefault(x => x.Value == (target - nums[i])).Key;              
                }
                hash.Add(i, nums[i]);
            }
            return result;
        }
    }
}
