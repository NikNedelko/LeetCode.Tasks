public class Solution {
    public int AddDigits(int num) {
        if (num == 0) return 0;
        return 1 + (num - 1) % 9;
    }
}

public class Solution {
    public int AddDigits(int num) {
        while(num > 9){
            num = Convert.ToString(num)
                .ToArray()
                .Select(x =>Convert.ToInt32(Convert.ToString(x)))
                .Sum();
        }
        
        return num;
    }
}