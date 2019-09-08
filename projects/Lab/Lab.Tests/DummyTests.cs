using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLossesHealthWhenAtacked()
        {
            Dummy dummy = new Dummy(20, 10);

            dummy.TakeAttack(10);

            Assert.AreEqual(10, dummy.Health, "message");
        }

        [Test]
        public void DummyThrowsExceptionIfAtackedWhenDead()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1));
        }
    }
}
