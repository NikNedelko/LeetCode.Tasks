public class Solution {
    public int[] MinOperations(string boxes) {
        var result = new List<int>();

        for(var i = 0; i < boxes.Length; i++){
            var sum = 0;

            for(var j = 0; j < boxes.Length; j++){
                if(boxes[j] == '1'){
                    if(i > j)
                        sum += i - j;
                    else
                        sum += j - i;
                }
            }

            result.Add(sum);
        }

        return result.ToArray();
    }
}