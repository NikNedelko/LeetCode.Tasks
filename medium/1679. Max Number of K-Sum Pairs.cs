public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        var hash = new Dictionary<int, int>();
        var res = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (hash.ContainsKey(k - nums[i]))
            {
                res++;
                hash[k - nums[i]]--;

                if (hash[k - nums[i]] < 1)
                {
                    hash.Remove(k - nums[i]);
                }
            }

            else
            {
                if (hash.ContainsKey(nums[i]))
                    hash[nums[i]]++;
                else
                    hash.Add(nums[i], 1);
            }
        }

        return res;
    }
}

public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var res = 0;
        Array.Sort(nums);
        int p1 = 0, p2 = nums.Length - 1;

        while(p1 < p2){
            var sum = nums[p1] + nums[p2];

            if(sum == k){
                res++;
                p1++;
                p2--;
                continue;
            }

            if(sum > k)
                p2--;
            else
                p1++;
        }

        return res;
    }
}