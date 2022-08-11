using QuickSort;
using RandomNameGeneratorLibrary;
using Xunit;
using Xunit.Abstractions;
using System.RandomExtension;

namespace XUnitTestQuickSort
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _output;
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact(DisplayName = "01 - Sbyte Test")]
        public void Test01()
        {
            const int seed = 250;
            const int maxLength = 10;
            
            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            sbyte[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextSByte(sbyte.MinValue, sbyte.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "02 - Byte Test")]
        public void Test02()
        {
            const int seed = 250;
            const int maxLength = 10;
            
            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            byte[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextByte(byte.MinValue, byte.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "03 - Short Test")]
        public void Test03()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            short[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextShort(short.MinValue, short.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "04 - UShort Test")]
        public void Test04()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            ushort[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextUShort(ushort.MinValue, ushort.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "05 - Int Test")]
        public void Test05()
        {
            const int seed = 250;
            const int maxLength = 10;
            
            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            int[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.Next(int.MinValue, int.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "06 - UInt Test")]
        public void Test06()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            uint[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextUInt(uint.MinValue, uint.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "07 - Long Test")]
        public void Test07()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            long[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextLong(long.MinValue, long.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "08 - ULong Test")]
        public void Test08()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            ulong[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextULong(ulong.MinValue, ulong.MaxValue)).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "09 - Float Test")]
        public void Test09()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            float[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextFloat()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "10 - Decimal Test")]
        public void Test10()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            decimal[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextDecimal()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "11 - Double Test")]
        public void Test11()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            double[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.NextDouble()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "12 - String Places Test")]
        public void Test12()
        {
            const int seed = 250;
            const int maxLength = 10;
            
            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            string[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.GenerateRandomPlaceName()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "13 - String Male Name Test")]
        public void Test13()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            string[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.GenerateRandomMaleFirstAndLastName()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "14 - String Female Name Test")]
        public void Test14()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);
            string[] arr = Enumerable.Repeat(0, arrayLength).Select(i => rnd.GenerateRandomFemaleFirstAndLastName()).ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
            _output.WriteLine("Unsorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            int n = arr.Length;
            Assert.Equal(arr.OrderBy(x => x).ToArray(), QuickSortClass.QuickSort(arr, 0, n - 1));
            _output.WriteLine("Sorted Array:");
            _output.WriteLine($"[{string.Join(" , ", arr)}]");
            _output.WriteLine("--------------------------");
        }
        [Fact(DisplayName = "15 - DateTime")]
        public void Test15()
        {
            const int seed = 250;
            const int maxLength = 10;

            Random rnd = new Random(seed);
            int arrayLength = rnd.Next(1, maxLength);

            List<DateTime> randomDays = new List<DateTime>();
            for (int i = 0; i < arrayLength; i++)
            {
                randomDays.Add(new DateTime(rnd.Next(1950, 2019), rnd.Next(1, 12), rnd.Next(1, 28), rnd.Next(0, 23), rnd.Next(0, 59), rnd.Next(0, 59)));
            }

            DateTime[] arr = randomDays.ToArray();
            _output.WriteLine("--------------------------");
            _output.WriteLine($"Seed Used: {seed}");
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