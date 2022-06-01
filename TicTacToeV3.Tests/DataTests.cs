using Xunit;
namespace TicTacToeV3.Tests
{
    public class DataTests
    {
        [Theory]
        [InlineData("a1", "a1")]
        [InlineData("1a", "a1")]
        public void CheckAndOrder_When_Then(string no, string uz)
        {
            string ret = Data.CheckAndOrder(no);
            Assert.Equal(uz, ret);
        }
    }
}
