using QuickSort;
using Xunit;
namespace XUnitTestQuickSort
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Integer Test 1")]
        public void Test01()
        {
            int[] arr = { 4, 3, 5, 1, 2 };
            int n = arr.Length;
            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
        [Fact(DisplayName = "Integer Test 2")]
        public void Test02()
        {
            int[] arr = { 845, 12, 44, 105, 18, 280, 58, 360, 82, 624 };
            int n = arr.Length;
            Assert.Equal(new int[] { 12, 18, 44, 58, 82, 105, 280, 360, 624, 845 }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
        [Fact(DisplayName = "Integer Test 3")]
        public void Test03()
        {
            int[] arr = { 25, 158, 5, 654, 2, 2500, 32, 3645, 6648, 33, 42, 487, 336, 8, 998 };
            int n = arr.Length;
            Assert.Equal(new int[] { 2, 5, 8, 25, 32, 33, 42, 158, 336, 487, 654, 998, 2500, 3645, 6648 }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
        [Fact(DisplayName = "String Test 1")]
        public void Test04()
        {
            string[] arr = { "A", "C", "G", "H", "B", "K", "Q", "M" };
            int n = arr.Length;
            Assert.Equal(new string[] { "A", "B", "C", "G", "H", "K", "M", "Q" }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
        [Fact(DisplayName = "String Test 2")]
        public void Test05()
        {
            string[] arr = { "Jens Peter", "Hans Madsen", "Julie Bertelsen", "Axel Gregersen", "Konrad Pedersen", "Aske Bak" };
            int n = arr.Length;
            Assert.Equal(new string[] { "Aske Bak", "Axel Gregersen", "Hans Madsen", "Jens Peter", "Julie Bertelsen", "Konrad Pedersen" }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
        [Fact(DisplayName = "String Test 3")]
        public void Test06()
        {
            string[] arr = { "Chrysler", "Honda", "Volkswagen", "Dodge", "Audi", "BMW", "Cadillac", "Chevrolet" };
            int n = arr.Length;
            Assert.Equal(new string[] { "Audi", "BMW", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Honda", "Volkswagen" }, QuickSortClass.QuickSort(arr, 0, n - 1));
        }
    }
}