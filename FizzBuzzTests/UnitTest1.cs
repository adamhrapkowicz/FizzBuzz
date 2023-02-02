using FizzBuzz;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            // Specify an input and an expected output fopr the method we want to test
            var number = 5;
            var expectedResult = new string[5] { "3", "2", "Fizz", "4", "Buzz" };

            // Act
            // Run method we want to test with the specified input
            var result = Program.GetFizzBuzzList(number);

            // Assert
            // Verify that the returned output from the method is the same as the expected output
            Assert.Equivalent(expectedResult, result);
        }
    }
}