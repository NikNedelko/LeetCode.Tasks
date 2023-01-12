public class Solution {
    public int FindGCD(int[] nums) {
        Array.Sort(nums);
        var smlNumber = nums[0];
        var grtNumber = nums[nums.Length - 1];
        if(grtNumber % smlNumber != 0){
            var newNumber = smlNumber - 1;
            while(true){
                if(newNumber == 1)
                    return 1;
                if(grtNumber % newNumber != 0){
                    newNumber--;
                    continue;
                }
                if(smlNumber % newNumber != 0){
                    newNumber--;
                    continue;
                }
                if(grtNumber % newNumber == 0 && smlNumber % newNumber == 0)
                    return newNumber;
            }
            return newNumber;
        }   
        return smlNumber;
    }
}