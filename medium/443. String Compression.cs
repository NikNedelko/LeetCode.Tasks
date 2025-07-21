public class Solution {
    public int Compress(char[] chars) {
        var dict = new Dictionary<int, int>();
        var list = new List<char>();
        var current = ' ';

        foreach(var ch in chars){
            if(current != ch){
                current = ch;
                list.Add(ch);
            }

            if(dict.ContainsKey(list.Count - 1)){
                dict[list.Count - 1]++;
            }
            else{
                dict.Add(list.Count - 1, 1);
            }
        }

        var index  = 0;

        foreach(var kv in dict){
            chars[index] = list.ElementAt(kv.Key);
            index++;

            if(kv.Value == 1)
                continue;

            var strValue = Convert.ToString(kv.Value);

            foreach(var str in strValue){
                chars[index] = str;
                index++;
            }
        }

        return index;
    }
}

public class Solution {
    public int Compress(char[] chars) {
        var length = chars.Length;
        var write  = 0;
        var anchor = 0;

        for(var i = 0; i < length; i++){

            if(i + 1 == length || chars[i] != chars[i + 1]){

                chars[write++] = chars[i];

                var count = i - anchor + 1;
                if(count > 1){
                    foreach(var ch in count.ToString()){
                        chars[write++] = ch;
                    }
                }

                anchor = i + 1;
            }
        }

        return write;
    }
}