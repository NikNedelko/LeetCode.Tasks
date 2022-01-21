821. Shortest Distance to a Character
public class Solution {
    public int[] ShortestToChar(string s, char c) {
        
        int[] ans = new int[s.Length];
        int count=0;
        bool flag=false;
        int startPoint=0;
        
        for(int i=0;i<s.Length;i++){
            if(s[i]==c){
                if(!flag)
                    startPoint=i;
                if(flag)
                    count=0;
                flag=true;
            }
            if(flag){
                ans[i]=count;
                count++;
            }
        }
        count=0;
        flag=false;
        
        for(int i=s.Length-1;i>=0;i--){
            if(s[i]==c){
                if(flag)
                    count=0;
                flag=true;
            }
            if(flag){
                if(i<=startPoint){
                    ans[i]=count;
                count++;
                    continue;
                }
                if(ans[i]>count)
                    ans[i]=count;
                count++;
            }
        }
        return ans;
    }
}