public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        var counter = 0;
        var words = text.Split(' ');
        for(int i = 0; i < words.Length; i++){
            var word = words[i];
            for(int j = 0; j < brokenLetters.Length; j++){
                if(word.Contains(brokenLetters[j])){
                    counter++;
                    break;
                }
            }
        }
        return words.Length - counter;
    }
}