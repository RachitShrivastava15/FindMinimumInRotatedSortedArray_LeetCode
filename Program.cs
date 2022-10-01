namespace FindMinimumInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,4,5,1,2};
            int result = FindMin(nums);
            Console.WriteLine(result);
        }

        public static int FindMin(int[] nums) 
        {
            int n = nums.Length;
            int a = findMin(nums, 0, n-1);
            return a;
        }
        
        static int findMin(int[] arr, int low, int high)
        {
            if(high < low)
                return arr[0];
            if(high == low)
                return arr[low];
            int mid = low + (high - low) /2;
            if(mid < high && arr[mid+1]<arr[mid])
                return arr[mid+1];
            if(mid > low && arr[mid] < arr[mid-1])
                return arr[mid];
            if(arr[high] > arr[mid])
                return findMin(arr, low, mid -1);
            return findMin(arr, mid+1, high);
        }
    }
}