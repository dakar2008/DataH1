namespace QuickSort
{
    public static class QuickSortClass
    {
        private static void Swap<T>(T[] arr, int i, int j)
        {
            //Swapping with tubles
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
        
        private static int Compare<T>(T left, T right)
        {
            return (left as IComparable<T>).CompareTo(right);
        }

        public static T[] QuickSort<T>(T[] arr, int left, int right)
        {
            if (left < right)
            {
                //Get pivot point
                int pivot = Partition(arr, left, right);
                //If pivot is greater than 1, call QuickSort  method with arr, left, pivot - 1
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                //If pivot + 1 is less than right, call QuickSort method with arr, pivot + 1, right
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
            return arr;
        }
        
        private static int Partition<T>(T[] arr, int left, int right)
        {
            //Use the first value in array as pivot
            T pivot = arr[left];
            while (true)
            {
                while (Compare(arr[left], pivot) < 0)
                {
                    //If the value is less than the pivot, move to the right
                    left++;
                }
                while (Compare(arr[right], pivot) > 0)
                {
                    //If the value is greater than the pivot, move to the left
                    right--;
                }
                if (left < right)
                {
                    //If the left index is less than the right index, swap the values
                    Swap(arr, left, right);
                }
                else
                {
                    return right;
                }
            }
        }
    }
}