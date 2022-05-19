// Maximum sum subarray of Size k
// Given an array of positive integers, and a positive number k, find the maximum sum of any contiguous subarray of size k.

class MaximumSumSubarrayOfSizek
{
    internal static int GetMaxSum(List<int> arr, int k)
    {
        int maxSum = 0;
        int windowSum = 0;
        int start = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            windowSum += arr[i];
            if (i - start + 1 == k)
            {
                maxSum = Math.Max(maxSum, windowSum);
                windowSum -= arr[start];
                start += 1;
            }
        }
        return maxSum;
    }
}