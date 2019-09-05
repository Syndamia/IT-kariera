using System;
using System.Collections.Generic;
using System.Text;
using _01._2_AxeDummy;
using NUnit.Framework;

namespace _01._2_AxeDummyTests {
    [TestFixture]
    class DummyTests {

        [Test]
        public static void AttackedDummyLoosesHealth() {
            Dummy testDummy = new Dummy(5, 5);

            testDummy.TakeAttack(2);

            Assert.IsTrue(5 > testDummy.Health, "Dummy doesn't loose health after being attacked.");
        }

        [Test]
        public static void AttackedDeadDummyThrowsException() {
            Dummy testDummy = new Dummy(0, 0);

            var testException = Assert.Throws<InvalidOperationException>(() => testDummy.TakeAttack(5));

            Assert.AreEqual("Dummy is dead.", testException.Message, "Dead dummy doesn't throw an exception after being attacked.");
        }

        [Test]
        public static void DeadDummyGivesXP() {
            Dummy testDummy = new Dummy(0, 10);

            Assert.AreEqual(10, testDummy.GiveExperience(), "Dead dummy doesn't return XP.");
        }

        [Test]
        public static void AliveDummyDoesntGiveXP() {
            Dummy testDummy = new Dummy(1 ,10);

            var testException = Assert.Throws<InvalidOperationException>(() => testDummy.GiveExperience());

            Assert.AreEqual("Target is not dead.", testException.Message, "Alive dummy gives XP.");
        }
    }
}
