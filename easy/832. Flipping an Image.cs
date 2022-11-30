public static int[][] FlipAndInvertImage(int[][] image)
    {
        var result = new int[image.Length][];
        for (int i = 0; i < image.Length; i++)
        {
            result[i] = new int[image.Length];
            for (int j = 0, k = image.Length - 1; j <= image.Length - 1; j++, k--)
            {
                result[i][j] = image[i][k] == 0 ? 1 : 0;
            }
        }

        return result;
    }