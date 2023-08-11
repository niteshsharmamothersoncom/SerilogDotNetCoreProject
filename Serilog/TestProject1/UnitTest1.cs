using Serilog.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string str = "this is string";
            Assert.Equal(str, str);
            Assert.True(true);
        }
    }
}