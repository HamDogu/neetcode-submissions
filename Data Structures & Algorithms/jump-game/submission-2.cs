public class Solution {
    public bool CanJump(int[] nums) {
        var goal = nums.Length - 1;
        Console.WriteLine($"Goal = {goal}");
        for (int i = goal; i > -1; i--) {
            if(nums[i] + i >= goal){
                goal = i;
            };
            Console.WriteLine($"Current Index {i} goal {goal}");
        }
        if(goal == 0) return true;

        return false;
    }
}
