namespace CIS122_HW9
{
    public class Problem1
    {
        public void MoveZeroes(int[] nums)
        {
            int j = 0; // j keeps track of where to put the next non-zero

            // Step 1: Move all non-zero numbers to the front
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i]; // Put non-zero at the front
                    j++; // Move to next position
                }
            }

            // Step 2: Fill the rest with zeros
            while (j < nums.Length)
            {
                nums[j] = 0;
                j++;
            }
        }
    }
}
