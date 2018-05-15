using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MVCSOLIDDemo.Solution.Domain.Tests {

    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Tests.Helpers.Domain;
    using System.Linq;

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

        [TestMethod]
        public void TestDomainUserAddAddress() {

            var expectedAddress = UserTesterHelper.AddressExpected;

            var listAddress = (List<IAddress>) A.CollectionOfFake<IAddress>(0);

            var user = new User(UserTesterHelper.Name, 
                                UserTesterHelper.Surname, 
                                UserTesterHelper.Email, 
                                UserTesterHelper.Password, 
                                UserTesterHelper.Gender, 
                                UserTesterHelper.DateOfBirth, 
                                listAddress);


            user.AddAddress(expectedAddress);

            var addressComparable = user.Addresses.ElementAt(0);

            Assert.AreEqual(addressComparable, expectedAddress);

        }

        [TestMethod]
        public void TestDomainUserRemoveAddress() {

            var expectedAddress = UserTesterHelper.AddressExpected;

            var listAddress = (List<IAddress>) A.CollectionOfFake<IAddress>(0);

            var user = new User(UserTesterHelper.Name, 
                                UserTesterHelper.Surname, 
                                UserTesterHelper.Email, 
                                UserTesterHelper.Password, 
                                UserTesterHelper.Gender, 
                                UserTesterHelper.DateOfBirth, 
                                listAddress);


            user.AddAddress(expectedAddress);
            user.RemoveAddress(expectedAddress);
            
            Assert.IsTrue(user.Addresses.Count()<=0);

        }

    }
}
