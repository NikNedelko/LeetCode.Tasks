public void MoveZeroes(int[] nums) {
        for (int i = 0, j = 0; i < nums.Length;)
        {
            if (nums[i] == 0)
            {
                j = i + 1;
                while (j < nums.Length && nums[j] == 0)
                {
                    j++;
                }

                if (j < nums.Length && i < j)
                {
                    nums[i] = nums[j];
                    nums[j] = 0;
                }
            }

            i++;
        }
    }