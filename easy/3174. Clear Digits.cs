public class Solution {
    public string ClearDigits(string s) {
        var stack = new Stack<char>();

        for(var i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i])){
                stack.Pop();
            }
            else{
                stack.Push(s[i]);
            }
        }

        var sb = new StringBuilder();

        foreach(var ch in stack){
            sb.Insert(0, ch);
        }
        return sb.ToString();
    }
}