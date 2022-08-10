using QuickSort;
using RandomNameGeneratorLibrary;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestQuickSort
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact(DisplayName = "Integer Test")]
        public void Test01()
        {
            Random rnd = new Random();
            int arrayLength = rnd.Next(1, 25);
            int[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.Next(1, 5000)).ToArray();
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "String Test")]
        public void Test02()
        {
            var placegenerator = new PlaceNameGenerator();
            Random rnd = new Random();
            int arrayLength = rnd.Next(1, 25);
            string[] arr = placegenerator.GenerateMultiplePlaceNames(arrayLength).ToArray();
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
    }
}