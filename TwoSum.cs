public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> indices = new List<int>();
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            indices.Add(i);
                            indices.Add(j);
                            return indices.ToArray();
                        }
                    }
                }
                return indices.ToArray();
    }
}