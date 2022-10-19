using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestAPI.Logic;

namespace TestDateAndTime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CallDateAndTime_ReturnCurrentDateAndTime() {

            var myMoq = new Moq.Mock<IDateTimeProvider>();
            myMoq.Setup(m => m.GetNow()).Returns(new DateTime(2020, 10, 15));

            Assert.AreEqual(new DateTime(2020, 10, 15), myMoq.Object.GetNow());
        }
    }
}
