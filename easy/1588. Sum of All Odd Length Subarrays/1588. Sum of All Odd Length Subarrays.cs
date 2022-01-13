1588. Sum of All Odd Length Subarrays
public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int ans = 0;
        for(int i=0;i<arr.Length;i++){
            int j = 1;
            while(j<=arr.Length){
                var array = new int[j];
                try{
                    for(int k=0,z=i;k<j;k++,z++)
                        array[k]=arr[z];  
                }
                catch(System.Exception){
                 break;
                }  
                foreach(var num in array)
                    ans+=num;
                j+=2;
            }
        }
        return ans;
    }
}