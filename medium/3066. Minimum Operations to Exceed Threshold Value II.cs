public class Solution {
    public int MinOperations(int[] nums, int k) {
        var queue = new PriorityQueue<long, long>();

        foreach(var num in nums){
            queue.Enqueue(num, num);
        }

        var result = 0;

        while(queue.Count > 1){

        long x = queue.Dequeue();
            long y = queue.Dequeue();

            if(x >= k)
                break;

            
            long res = (Math.Min(x, y) * 2 + Math.Max(x, y));
            queue.Enqueue(res, res);

            result++;
        }

        return result;
    }
}