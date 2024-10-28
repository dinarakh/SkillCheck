using Xunit;


public class MathTests
{
    /*
     * Тест на сложение двух чисел:
     */

    public static class MathHelper
    {
        // Метод для сложения двух чисел
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Метод для проверки, является ли число четным
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Метод для вычисления факториала числа
        public static int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative");

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Метод для деления двух чисел
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return a / b;
        }
    }

    [Fact]
    public void Add_two_numbers_and_returns_sum()
    {
        int result = MathHelper.Add(2, 3);
        Assert.Equal(5, result); // Ожидаемая сумма 2 + 3 = 5
    }

    /*
     * Тест на проверку четного числа
     */

    [Fact]
    public void Check_if_number_is_even_and_returns_true()
    {
        bool result = MathHelper.IsEven(4);
        Assert.True(result); // Ожидается true для четного числа
    }

    [Fact]
    public void Check_if_number_is_odd_and_returns_false()
    {
        bool result = MathHelper.IsEven(5);
        Assert.False(result); // Ожидается false для нечетного числа
    }

    /*
     * Тест на факториал числа:
     */

    [Fact]
    public void Calculate_factorial_of_number_and_returns_factorial()
    {
        int result = MathHelper.Factorial(5);
        Assert.Equal(120, result); // 5! = 120
    }

    /*
     * Тест на деление чисел:
     */

    [Fact]
    public void Divide_two_numbers_and_returns_quotient()
    {
        double result = MathHelper.Divide(10, 2);
        Assert.Equal(5, result); // Ожидается результат 10 / 2 = 5
    }

    [Fact]
    public void Divide_by_zero_and_throws_exception()
    {
        Assert.Throws<DivideByZeroException>(() => MathHelper.Divide(10, 0)); // Проверка на деление на ноль
    }
}
