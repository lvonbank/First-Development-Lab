using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GFUDemo_CS;

namespace UnitTestProject1
{
    [TestClass]
    public class AutomobileTest
    {
        [TestMethod]
        public void DefaultAutomobileIsInitializedCorrectly()
        {
            Automobile myAuto = new Automobile();
            Assert.IsTrue((myAuto.Model == "Not specified") && (myAuto.TopSpeed == -1));
        }
        [TestMethod]
        public void AutomobileWithModelNameCanStart()
        {
            string model = "Contoso";
            int topSpeed = 199;
            Automobile myAuto = new Automobile(model, topSpeed);

            myAuto.Start();
            Assert.IsTrue(myAuto.IsRunning == true);
        }
    }
}
