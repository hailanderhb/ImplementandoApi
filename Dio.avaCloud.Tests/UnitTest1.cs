using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dio.avaCloud.Entidades;

namespace Dio.avaCloud.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullName_Test_Is_Valid()
        {
            //Arrange
            Customer customer = new Customer()
            {
                FirstName = "Hailander",
                LastName = "Bastos"
            };

            string expected = "Hailander Bastos";
            //Act
            string result = customer.FullName;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
