using Xunit;


public class StringTests
{
    /*
     * Тест на обратную строку:
     */
    public static class StringHelper
    {
        public static string Reverse(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            string reversed = Reverse(input);
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static string Concatenate(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException(str1 == null ? nameof(str1) : nameof(str2));

            return str1 + str2;
        }
    }

    [Fact]
    public void Reverse_string_and_retuns_reversed_string()
    {
        string result = StringHelper.Reverse("hello");
        Assert.Equal("olleh", result); // Ожидается "olleh" для строки "hello"
    }

    /*
     * Тест на проверку палиндрома:
     */

    [Fact]
    public void Check_if_string_is_palindrome_and_returns_true()
    {
        bool result = StringHelper.IsPalindrome("madam");
        Assert.True(result); // "madam" является палиндромом
    }

    [Fact]
    public void Check_if_string_is_not_palindrome_and_returns_false()
    {
        bool result = StringHelper.IsPalindrome("hello");
        Assert.False(result); // "hello" не является палиндромом
    }

    /*
     * Тест на конкатенацию строк:
     */

    [Fact]
    public void Concatenate_two_strings_and_returns_concatenated_string()
    {
        string result = StringHelper.Concatenate("Hello", "World");
        Assert.Equal("HelloWorld", result); // Ожидается "HelloWorld" без пробела
    }
}

