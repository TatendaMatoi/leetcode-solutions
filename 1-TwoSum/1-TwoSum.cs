// Last updated: 7/13/2025, 10:41:57 PM
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int firstPointer = 0; firstPointer < nums.Length; firstPointer++) {
            for (int secondPointer = firstPointer + 1; secondPointer < nums.Length;secondPointer++) {
                if (nums[firstPointer] + nums[secondPointer] == target) {
                    return new int[] { firstPointer, secondPointer };
                }
            }
        }
        return new int[0];
    }
}