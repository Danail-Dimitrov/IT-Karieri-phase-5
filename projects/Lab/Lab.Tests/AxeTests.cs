using NUnit.Framework;
using System;

namespace Lab.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityWhenItAtacks()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void AtackWithBrokenAxeThrowsException()
        {
            Axe axe = new Axe(10, 1);
            Dummy dummy = new Dummy(20, 10);

            axe.Attack(dummy);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}
