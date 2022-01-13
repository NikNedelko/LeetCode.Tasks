2108. Find First Palindromic String in the Array
public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(var word in words){
            int left=0;
            int right=word.Length-1;
            while(left<=word.Length/2){
                if(word[left]==word[right]){
                    left++;
                    right--;
                }
                else
                    break;
            }
            if(left>word.Length/2)
            return word;
        }
        return "";
    }
}