using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
namespace ÅrstidMetodeUnitTest
{
    [TestClass]
    public class MetodeTestÅrstid
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            studerende student = new studerende("test1", 12, 1);

            //Act
            string årstid = student.Årstid();
            
            //Assert
            Assert.AreEqual("Vinter", årstid);
        }
    }
}
