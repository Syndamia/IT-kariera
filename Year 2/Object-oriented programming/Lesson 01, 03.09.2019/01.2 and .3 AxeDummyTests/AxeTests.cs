using System;
using _01._2_AxeDummy;
using NUnit.Framework;

namespace _01._2_AxeDummyTests {
    [TestFixture]
    public class AxeTests {

        [Test]
        public static void AxeLoosesDurabilityAfterAttack() {
            Axe testAxe = new Axe(5, 5);

            testAxe.Attack(new Dummy(5, 5));

            Assert.IsTrue(5 > testAxe.DurabilityPoints, "Axe doesn't loose durability after it is used.");
        }

        [Test]
        public static void BrokenAxeCantAttack() {
            Axe testAxe = new Axe(5, 0);

            var testException = Assert.Throws<InvalidOperationException>(() => testAxe.Attack(new Dummy(5, 5)));
            Assert.AreEqual("Axe is broken.", testException.Message, "Broken axe is able to attack.");
        }
    }
}
