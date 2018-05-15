using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.Solution.Domain.Tests {

    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Tests.Helpers.Domain;

    [TestClass]
    public class DomainTests {

        [TestMethod]
        public void TestDomainUserPropertieAge() {

            var listAddress = (List<IAddress>) A.CollectionOfFake<IAddress>(20);

            var user = new User(UserTesterHelper.Name, 
                                UserTesterHelper.Surname, 
                                UserTesterHelper.Email, 
                                UserTesterHelper.Password, 
                                UserTesterHelper.Gender, 
                                UserTesterHelper.DateOfBirth, 
                                listAddress);

            Assert.AreEqual(user.Age, UserTesterHelper.ExpectedAge);

        }


    }
}
