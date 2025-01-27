public class Solution {
    public int[] Decrypt(int[] code, int k) {
        var result = new int[code.Length];

        if(k == 0)
            return result;

        var point = 0;

        for(var i = 0; i < code.Length; i++){
            point = i;

            if(k < 0)
                point += k;
            else
                point++;

            for(var j = 0; j < Math.Abs(k); j++){
                if(point >= code.Length)
                        point = 0;

                if(point < 0)
                    point = code.Length + point;
                    
                result[i] += code[point];
                
                point++;
            }
        }

        return result;
    }
}