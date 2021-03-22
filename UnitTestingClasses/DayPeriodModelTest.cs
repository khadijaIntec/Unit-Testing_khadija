using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_khadija;


namespace UnitTestingClasses
{

    [TestFixture]
    public class DayPeriodModelTest
    {
        [Test]
        public void DayPeriod_WhenCalled_ReturnsNight()
        {
            var testtime = new DateTime(2003, 1, 1, 2, 0, 0);
            var result = DayPeriodModel.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Night"));
        }
        [Test]
        public void DayPeriod_WhenCalled_ReturnsMorning()
        {
            var testtime = new DateTime(2003, 1, 1, 6, 0, 0);
            var result = DayPeriodModel.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Morning"));
        }
        [Test]
        public void DayPeriod_WhenCalled_ReturnsNoon()
        {
            var testtime = new DateTime(2003, 1, 1, 13, 0, 0);
            var result = DayPeriodModel.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Noon"));
        }
        [Test]
        public void DayPeriod_WhenCalled_ReturnsEvening()
        {
            var testtime = new DateTime(2003, 1, 1, 18, 0, 0);
            var result = DayPeriodModel.GetTimeOfDay(testtime);
            Assert.That(result, Is.EqualTo("Evening"));
        }
    }
}
