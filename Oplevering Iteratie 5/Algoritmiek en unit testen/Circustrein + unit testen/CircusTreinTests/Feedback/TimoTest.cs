using Circustrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinTests
{
    [TestClass]
    public class TimoTest
    {
        [TestMethod]
        public void RefTestInt()
        {
            int x = 10; // [ref:@#*#$#)&#$12312, val: 10]

            ChangeNumber(x); // by value

            Assert.AreEqual(10, x);
        }

        private void ChangeNumber(int number)
        {
            number = number + 1; // [ref:abc, val: 11]
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        [TestMethod]
        public void RefTestPerson()
        {
            Person p = new Person { Name = "Kevin", Age = 20 }; // [ref:classABC123, val: P{name=kevin, age=[ref:666intBCA, val=20]}]

            CheckIfExists(p); // by value

            Assert.AreEqual("Timo", p.Name);
            Assert.AreEqual(26, p.Age);
        }

        private void CheckIfExists(Person p)
        {
            p.Name = "Timo";  //[ref:classABC123, val: P{name=Timo}]
            p.Age = 26; // [ref:classABC123, val: P{ age=[ref:intABC123, val=26]}]
        }
    }
}
