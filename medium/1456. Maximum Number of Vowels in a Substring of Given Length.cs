public class Solution
{
    private const string vowels = "aeiou";

    public int MaxVowels(string s, int k)
    {
        var result = 0;
        var q = new Queue<char>();
        var curSum = 0;

        for (var i = 0; i < k; i++)
        {
            if (vowels.Contains(s[i]))
            {
                curSum++;
            }

            q.Enqueue(s[i]);
        }
        result = curSum;

        for (var i = k; i < s.Length; i++)
        {
            if (vowels.Contains(q.Dequeue()))
            {
                curSum--;
            }

            q.Enqueue(s[i]);
            if (vowels.Contains(s[i]))
            {
                curSum++;
            }

            result = Math.Max(result, curSum);
        }

        return result;
    }
}

public class Solution {
    private const string vowels = "aeiou";

    public int MaxVowels(string s, int k) {
        var result = 0;    
        var curSum = 0;

        for(var i = 0; i < k; i++){
            if(vowels.Contains(s[i])){
                curSum++;
            }
        }  
        result = curSum;

        if(curSum == k)
                return curSum;

        for(var i = k; i < s.Length; i++){
            if(vowels.Contains(s[i - k]))
                curSum--;
            
            if(vowels.Contains(s[i]))
                curSum++;
            

            result = Math.Max(result, curSum);
        }

        return result;
    }
}