using SerilogDemo.Controllers;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
             string str = "this is string";
          Console.Write (     SerilogDemo.LogClass.GetMessage());
            Assert.Equal(str, str);
            Assert.True(true);
        }
    }
}