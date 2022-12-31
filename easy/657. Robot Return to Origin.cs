public class Solution {
    public bool JudgeCircle(string moves) {
        var x = 0;
        var y = 0;
        foreach(var move in moves){
            switch(move){
                case 'U':
                y++;
                break;
                case 'D':
                y--;
                break;
                case 'R':
                x++;
                break;
                case 'L':
                x--;
                break;

                default:
                break;
            }
        }
        return x == 0 && y == 0;
    }
}