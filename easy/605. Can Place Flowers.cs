public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if(n == 0)
                return true;

        var left = true;
        var right = true;

        for(var i = 0; i < flowerbed.Length && n > 0; i++){

            left = true;
            right = true;

            if(i - 1 >= 0){
                if(flowerbed[i - 1] != 0)
                    left = false;
            }

            if(i + 1 < flowerbed.Length){
                if(flowerbed[i + 1] != 0)
                    right = false;
            }

            if(left && right && flowerbed[i] == 0){
                flowerbed[i] = 1;
                    n--;
            }
        }

        return n == 0;
    }
}

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int length = flowerbed.Length;
        
        for (int i = 0; i < length && n > 0; i++) {
            if (flowerbed[i] != 0) 
                continue;
            
            bool emptyLeft  = (i == 0)         || (flowerbed[i - 1] == 0);
            bool emptyRight = (i == length - 1)   || (flowerbed[i + 1] == 0);
            
            if (emptyLeft && emptyRight) {
                flowerbed[i] = 1;  
                n--;
            }
        }
        
        return n <= 0;
    }
}