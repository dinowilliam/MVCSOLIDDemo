using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MVCSOLIDDemo.Solution.Domain.Tests {

    using MVCSOLIDDemo.Domain.Models;
    using MVCSOLIDDemo.Domain.Models.Contracts;
    using MVCSOLIDDemo.Tests.Helpers.Domain;

    [TestClass]
    public class DomainTests {

        List<IAddress> listAddressFull;
        List<IAddress> listAddressEmpty;
        IAddress expectedAddress;
        IUser user;        

        public void TestDomainUserInit() {  
            listAddressFull = (List<IAddress>) A.CollectionOfFake<IAddress>(20);
            listAddressEmpty = (List<IAddress>) A.CollectionOfFake<IAddress>(0);
            expectedAddress = UserTesterHelper.AddressExpected;        
            
            user = new User(UserTesterHelper.Name, 
                            UserTesterHelper.Surname, 
                            UserTesterHelper.Email, 
                            UserTesterHelper.Password, 
                            UserTesterHelper.Gender, 
                            UserTesterHelper.DateOfBirth, 
                            listAddressEmpty);

        }

        [TestMethod]
        public void TestDomainUserPropertieAge() {

            TestDomainUserInit();               

            Assert.AreEqual(user.Age, UserTesterHelper.ExpectedAge);
        }

        [TestMethod]
        public void TestDomainUserReadAddressList() {

            TestDomainUserInit();               

            A.CallTo(() => user.Addresses).Returns(listAddressFull);

            Assert.IsTrue(user.Addresses.Count() == 20);
        }
       
        [TestMethod]
        public void TestDomainUserAddAddress() {   
            
            TestDomainUserInit();
           
            user.AddAddress(expectedAddress);

            var addressComparable = user.Addresses.ElementAt(0);

            Assert.AreEqual(addressComparable, expectedAddress);
        }

        [TestMethod]
        public void TestDomainUserRemoveAddress() {           

            TestDomainUserInit(); 

            user.AddAddress(expectedAddress);
            user.RemoveAddress(expectedAddress);
            
            Assert.IsTrue(user.Addresses.Count()<=0);
        }

    }
}
