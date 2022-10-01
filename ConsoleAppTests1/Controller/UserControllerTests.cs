using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var birthDay = DateTime.Now.AddYears(-18);
            var weight = 55;
            var height = 180;
            var gender = "male";
            var controller = new UserController(userName);
            //Act
            controller.SetNewUserData(gender, birthDay, weight, height);
            var controller2 = new UserController(userName);
            //Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            //Act
            var controller = new UserController(userName);
            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}