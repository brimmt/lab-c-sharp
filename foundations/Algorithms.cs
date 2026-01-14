namespace LABCSHARP 
{
public class Algorithms
    {
        public static bool FindTarget(int[] nums, int target)
        {
            foreach (int num in nums)
            {
                if (num == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}