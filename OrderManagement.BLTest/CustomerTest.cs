﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.BL;

namespace OrderManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FirstNameAndLastNameTest()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Jan";
            customer.LastName = "Kowalski";

            string expectedValue = "Jan Kowalski";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FirstNameAndLastNameTestSurnameIsNull()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Kowalski";

            string expectedValue = "Kowalski";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void FirstNameAndLastNameTestNameIsNull()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Jan";

            string expectedValue = "Jan";

            //Act
            string actualValue = customer.FirstNameAndLastName;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        //[TestMethod]
        //public void FirstNameAndLastNameTestNameAndSurnameIsNull()
        //{
        //    //Arrange
        //    Customer customer = new Customer();

        //    //Act
        //    string actualValue = customer.FirstNameAndLastName;

        //    //Assert
        //    Assert.ThrowsException<ArgumentNullException>(()=> actualValue);
        //}

    }
}
