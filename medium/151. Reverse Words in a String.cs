public class Solution {
    public string ReverseWords(string s) {
        if(!s.Contains(' '))
            return s;

        var arr = s.Split(' ');

        var sb = new StringBuilder();

        for(var i = arr.Length - 1; i >= 0; i--){
            if(arr[i] != ""){
                sb.Append(arr[i] + ' ');
            }
        }
        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}

public class Solution {
    public string ReverseWords(string s) {
        var arr = s.Split(' ').Where(x => x != "").ToArray();
        Array.Reverse(arr);

        return String.Join(' ', arr);
    }
}

