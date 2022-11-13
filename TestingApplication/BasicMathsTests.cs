using DemoConsoleApplication;

namespace TestingApplication
{
    [TestClass]
    public class BasicMathsTests
    {
        BasicMaths basicMaths = new BasicMaths(); 

        [TestMethod]
        public void Test_Add()
        {
            Assert.AreEqual<double>(TestData.AdditionResult, basicMaths.Add(TestData.Data1, TestData.Data2));
        }

        [TestMethod]
        public void Test_Substract()
        {
            Assert.AreEqual<double>(TestData.SubtractionResult, basicMaths.Substract(TestData.Data1, TestData.Data2));
        }

        [TestMethod]
        public void Test_Multiply()
        {
            Assert.AreEqual<double>(TestData.MultiplionResult, basicMaths.Multiply(TestData.Data1, TestData.Data2));
        }

        [TestMethod]
        public void Test_Divide()
        {
            Assert.AreEqual<double>(TestData.DivisionResult, basicMaths.Divide(TestData.Data1, TestData.Data2));
        }


    }
}
