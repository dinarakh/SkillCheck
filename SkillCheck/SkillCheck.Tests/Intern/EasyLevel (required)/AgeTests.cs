using Xunit;


namespace SkillCheck.Tests.Intern
{
    public class AgeTests
    {
        /*
         * Тест на проверку возраста:
         */
        public static class PersonHelper
        {
            public static bool IsAdult(int age)
            {
                return age >= 18;
            }
        }

        [Fact]
        public void Check_if_age_is_18_or_more_and_returns_true()
        {
            bool result = PersonHelper.IsAdult(18);
            Assert.True(result); // Человек в возрасте 18 лет является взрослым
        }

        [Fact]
        public void Check_if_age_is_less_than_18_and_returns_false()
        {
            bool result = PersonHelper.IsAdult(17);
            Assert.False(result); // Человек в возрасте 17 лет не является взрослым
        }
    }
}
