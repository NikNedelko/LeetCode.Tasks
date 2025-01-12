public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        var positionX = 0;
        var positionY = 0;

        foreach(var command in commands){
            switch(command){
                case "UP":
                    positionY--;
                    break;

                case "DOWN":
                    positionY++;
                    break;

                case "RIGHT":
                    positionX++;
                    break;

                case "LEFT":
                    positionX--;
                    break;
            }
        }

        return positionX + (positionY * n);
    }
}