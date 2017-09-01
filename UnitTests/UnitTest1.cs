using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var result = await SignInManager.PasswordSignInAsync(Module.Email, model.Password, model.RememberMe = false, shouldLockout: false);
            Assert
        }
    }
}
