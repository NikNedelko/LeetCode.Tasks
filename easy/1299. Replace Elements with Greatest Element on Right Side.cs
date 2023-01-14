public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for(int i = 0; i < arr.Length; i++){
            if(i+1< arr.Length)
                arr[i] = arr[i+1];
            for(int j = i+1; j < arr.Length; j++){
                if(arr[i] < arr[j])
                    arr[i] = arr[j];
            }
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}