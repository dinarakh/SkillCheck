using Xunit;
public class ArrayTests
{
    /*
     * Тест на поиск максимального числа в массиве:
     */
    public static class ArrayHelper
    {
        // Метод для поиска максимального значения в массиве
        public static int Max(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array cannot be null or empty");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        // Метод для сортировки массива
        public static int[] Sort(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            int[] sortedArray = (int[])numbers.Clone();
            Array.Sort(sortedArray);
            return sortedArray;
        }
    }
    [Fact]
    public void Find_max_number_in_array_and_returns_max_value()
    {
        int result = ArrayHelper.Max(new int[] { 1, 5, 3, 9, 2 });
        Assert.Equal(9, result); // Ожидается 9 как максимальное число
    }

    /*
     * Тест на сортировку массива
     */

    [Fact]
    public void Sort_array_and_returns_sorted_array()
    {
        int[] result = ArrayHelper.Sort(new int[] { 3, 1, 4, 2 });
        Assert.Equal(new int[] { 1, 2, 3, 4 }, result); // Ожидается отсортированный массив
    }
}

