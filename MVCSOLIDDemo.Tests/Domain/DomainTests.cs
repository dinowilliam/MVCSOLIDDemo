using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.Domain.Tests {

    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;

    [TestClass]
    public class DomainTests {

        [TestMethod]
        public void TestDomainUserPropertieAge() {

            var listAddress = A.Fake<List<IAddress>>(); 

            var user = new User("Usuario", "", "", "", "", DateTime.Now.AddYears(-37), listAddress);

            Assert.AreEqual(user.Age, 37);

        }


    }
}
