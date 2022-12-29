using NUnit.Framework;

namespace OneDimArrays2.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new[] { -20, -19, -9, -7, -2, 11 }, 5)]
        [TestCase(new[] { -19, -8, -3, -2, 0, 2, 3, 10 }, 4)]
        [TestCase(new[] { -12, -9, 8, 9, 10, 13 }, 2)]
        public void Task1_ReturnsCorrectValue(int[] array, int expected)
        {
            var actual = Tasks.Task1(array);

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }

        [TestCase(new[] { -20, -19, -9, -7, -2, 11 }, 0, 11)]
        [TestCase(new[] { -19, -8, -3, -2, 0, 2, 3, 10 }, 2, 30)]
        [TestCase(new[] { -12, -9, 8, 9, 10, 13 }, 2, 9360)]
        public void Task2_ReturnsCorrectValue(int[] array, int a, int expected)
        {
            var actual = Tasks.Task2(array, a);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(new[] { 0, -19, -9, 3, -2, 11 }, 2)]
        [TestCase(new[] { -19, 1, -3, -2, 4, 2, 6, 10 }, 3)]
        [TestCase(new[] { -12, -9, 8, 9, 10, 5 }, 1)]
        public void Task3_ReturnsCorrectValue(int[] array, int expected)
        {
            var actual = Tasks.Task3(array);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }

    }
}
