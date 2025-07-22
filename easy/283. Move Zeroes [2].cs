public class Solution {
    public void MoveZeroes(int[] nums) {
        var q = new Queue<int>();

        for(var i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                q.Enqueue(i);
            }
            else if(q.Count > 0){
                nums[q.Dequeue()] = nums[i];
                nums[i] = 0;
                q.Enqueue(i);
            }
        }
    }
}