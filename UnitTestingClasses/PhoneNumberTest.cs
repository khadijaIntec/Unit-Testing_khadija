using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Unit_Testing_khadija;

namespace UnitTestingClasses
{
    [TestFixture]
    public class PhoneNumberTest
    {
        [Test]
        public void PhoneNumber_When_ReturnsPhoneNumber(int input)
        {
            //ARRANGE


            var result = PhoneNumber.GetOutput(input);
            Assert.That(result, Is.EqualTo("Area "));
        }

    }
    [Test]
    public void PhoneNumber_When_ReturnsPhoneNumber(int input)
    { 


        var result = PhoneNumber.GetOutput(input);
        Assert.That(result, Is.EqualTo("Major"));
    }
    [Test]

    public void PhoneNumber_When_ReturnsPhoneNumber(int input)
    {
        //Assert
        var result = PhoneNumber.GetOutput(input);
        Assert.That(result, Is.EqualTo(" Minor"));
    }
    //[Test]

    //public void PhoneNumber_When_ReturnsPhoneNumber(int input)
    //{
    //    var result = PhoneNumber.GetOutput(input);
    //    Assert.That(result, Is.EqualTo(input.ToString()));
    //}
}


