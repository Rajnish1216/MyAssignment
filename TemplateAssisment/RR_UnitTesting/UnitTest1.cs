using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TemplateAssisment;

namespace RR_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        MainClass MainClass = new MainClass();
        [TestMethod]
        public void TestMethod1()
        {
            MainClass.Bullet = 3;
            MainClass.spinBullet = 3;
            Assert.AreEqual("Game Over !! You Loose the game", MainClass.Shoot());
        }

        [TestMethod]
        public void TestMethod2()
        {
            MainClass.Bullet = 3;
            MainClass.spinBullet = 4;
            Assert.AreEqual("Empty Bullet", MainClass.Shoot());
        }
    }
}
