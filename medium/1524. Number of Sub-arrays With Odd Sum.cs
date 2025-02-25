public class Solution {
    public int NumOfSubarrays(int[] arr) {
        var mod = 1000000007;
        var total = 0;
        var even = 1;
        var odd = 0;
        long prefSum = 0;

        for(var i = 0; i < arr.Length; i++){
            prefSum += arr[i];

            if(prefSum % 2 != 0){
                total =(total + even) % mod;
                odd++;
            }
            else{
                total = (total + odd) % mod;
                even++;
            }
        }

        return total;
    }
}



/*
public class Solution {
    public int NumOfSubarrays(int[] arr) {
        var result = 0;

        for(var ws = 1; ws <= arr.Length; ws++){
            
            for(var start = 0; start + ws <= arr.Length; start++){

                var subSum = 0;
                for(var i = 0; i < ws; i++){
                    subSum += arr[i + start];
                }

                if(subSum % 2 != 0)
                    result++;
            }
        }

        return result;
    }
}
*/

PS

Why Use mod = 1000000007?
Avoid Integer Overflow
In C#, int has a maximum value of 2^31 - 1 = 2147483647.
Since your sum grows with each iteration, without mod, total could exceed this limit, causing overflow.
Prime Modulo Property
1000000007 is a large prime number, which helps maintain the properties of modulo arithmetic.
Using a prime mod ensures fair distribution of values and prevents bias in results.
Efficient Computations
The modulo operation keeps numbers manageable while maintaining correctness.
Modulo arithmetic ensures that intermediate values never get too large.
What Happens Without mod?
If mod is removed, total keeps increasing indefinitely.
For very large arr, integer overflow occurs, leading to incorrect results.

Example:

public class Solution {
    public int NumOfSubarrays(int[] arr) {
        var total = 0;
        var even = 1;
        var odd = 0;
        long prefSum = 0;

        for(var i = 0; i < arr.Length; i++){
            prefSum += arr[i];

            if(prefSum % 2 != 0){
                total = total + even; // Can overflow!
                odd++;
            }
            else{
                total = total + odd; // Can overflow!
                even++;
            }
        }

        return total; // Might return incorrect values due to overflow
    }
}
If total exceeds 2147483647, it will wrap around into negative values (integer overflow), producing incorrect answers.

Final Takeaway
Using mod = 1000000007 ensures: ✔ Correctness – No overflow errors.
✔ Efficiency – Keeps numbers small for fast computation.
✔ Reliability – Prime mod maintains fair results in modulo arithmetic.