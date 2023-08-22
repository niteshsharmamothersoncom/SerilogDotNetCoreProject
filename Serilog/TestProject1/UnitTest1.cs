using SerilogDemo.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
             string str = "this is string";
           // SerilogDemo s = new SerilogDemo();
           
            Assert.Equal(str, str);
            Assert.True(true);
        }
    }
}