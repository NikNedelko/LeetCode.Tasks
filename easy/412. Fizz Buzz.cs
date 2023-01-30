public class Solution {
    public IList<string> FizzBuzz(int n) {
        var list = new List<string>();
        for(int i = 1; i <= n; i++){
            if(i%3==0){
                if(i%5==0){
                    list.Add("FizzBuzz");
                    continue;
                }
                list.Add("Fizz");
                continue;
            }
            if(i%5==0){
                list.Add("Buzz");
                continue;
            }
            list.Add(Convert.ToString(i));
        }
        return list;
    }
}