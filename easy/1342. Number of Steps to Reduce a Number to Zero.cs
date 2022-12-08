public class Solution {
    public int NumberOfSteps(int num) {
        var count = 0;
        while(num!=0){
            if(num%2!=0){
                num--;
                count++;
                continue;
            }
            
            if(num==0) break;

            num /= 2;
            count++;
        }
        return count;
    }
}