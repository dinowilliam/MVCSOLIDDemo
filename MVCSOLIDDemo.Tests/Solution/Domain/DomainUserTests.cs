using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MVCSOLIDDemo.Solution.Domain.Tests
{

    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Tests.Helpers.Domain;    

    [TestClass]
    public class DomainUserTests
    {

        List<IAddress> listAddressFull;
        List<IAddress> listAddressEmpty;
        IAddress expectedAddress;
        User user;

        [TestInitialize]
        public void TestDomainUserInit()
        {
            listAddressFull = (List<IAddress>)A.CollectionOfFake<IAddress>(20);
            listAddressEmpty = (List<IAddress>)A.CollectionOfFake<IAddress>(0);
            expectedAddress = UserTesterHelper.ExpectedAddress;

            user = A.Fake<User>(x => x.WithArgumentsForConstructor(() => new
                            User(UserTesterHelper.Name,
                                 UserTesterHelper.Surname,
                                 UserTesterHelper.Email,
                                 UserTesterHelper.Password,
                                 UserTesterHelper.Gender,
                                 UserTesterHelper.DateOfBirth,
                                 listAddressEmpty)
           ));

        }

        [TestMethod]
        public void TestDomainUserPropertieAge()
        {
            Assert.AreEqual(user.Age, UserTesterHelper.ExpectedAge);
        }

        [TestMethod]
        public void TestDomainUserReadAddressList()
        {

            var userFullAddress = A.Fake<User>(x => x.WithArgumentsForConstructor(() => new
                                       User(UserTesterHelper.Name,
                                            UserTesterHelper.Surname,
                                            UserTesterHelper.Email,
                                            UserTesterHelper.Password,
                                            UserTesterHelper.Gender,
                                            UserTesterHelper.DateOfBirth,
                                            listAddressFull)
            ));


            Assert.IsTrue(userFullAddress.Addresses.Count() == 20);
        }

        [TestMethod]
        public void TestDomainUserAddAddress()
        {

            user.AddAddress(expectedAddress);

            var addressComparable = user.Addresses.ElementAt(0);

            Assert.AreEqual(addressComparable, expectedAddress);
        }

        [TestMethod]
        public void TestDomainUserRemoveAddress()
        {
            user.AddAddress(expectedAddress);
            user.RemoveAddress(expectedAddress);

            Assert.IsTrue(user.Addresses.Count() <= 0);
        }

        [TestCleanup]
        public void TestDomainUserCleanup()
        {

        }

    }
}
