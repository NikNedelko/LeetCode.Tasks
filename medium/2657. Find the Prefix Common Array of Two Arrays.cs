public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        var result = new int[A.Length];
        var hash   = new HashSet<int>();

        for(var i = 0; i < A.Length; i++){
            if(!hash.Contains(B[i]))
                hash.Add(B[i]);

            var count = 0;

            for(var j = 0; j <= i; j++){
                if(hash.Contains(A[j]))
                    count++;
            }

            result[i] = count;
        }

        return result;
    }
}