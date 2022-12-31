public class Solution {
    public int MySqrt(int x) {
        if(x*x==x)
            return x;
        var number = Math.Truncate(Convert.ToDouble(x/2));
        while(true){
            if(number * number <= x && (number+1) * (number+1) >= x){
                if((number+1) * (number+1) == x)
                    return Convert.ToInt32(number+1);
                return Convert.ToInt32(number);
            }
            if(number * number < x){
                number++;
                continue;
            }
            if(number * number > x){
                number = Math.Truncate(number/2);
            }
        }
    }
}