using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCSOLIDDemo.Tests.CrossCutting.Utils {
    
    using MVCSOLIDDemo.Utils.Helpers.Primitives;

    [TestClass]
    public class UtilsTestsStringHelper
    {

        [TestMethod]
        public void TestUtilsStringHelperHashMD5() {
            
            var stringMD5 = StringHelper.HashMD5("AAAAAAAAA");

            Assert.AreEqual(stringMD5, "6c9395cacd317eed2777f669103b7181");
        }

    }
}
