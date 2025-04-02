using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain10.RentalCar10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain10.RentalCar10.Tests
{
    [TestClass()]
    public class TestCar
    {
        [TestMethod()]
        public void Test_CalculateRentalCost()
        {
            // Arrange
            IVehicle target = new Car(ModelType.Toyota);
            int actual;
            int expected = 300;

            // Act
            actual = target.CalculateRentalCost(3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}