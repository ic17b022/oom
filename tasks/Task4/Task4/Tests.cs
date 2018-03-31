using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void lizardsAreColdBloodedTest()
        {
            Lizard lizard = new Lizard(10, 0.1M);
            Assert.IsFalse(lizard.isWarmblooded());
        }

        [Test]
        public void humansAreWarmBloodedTest()
        {
            Human human = new Human(180, "Test", "Test", 70);
            Assert.IsTrue(human.isWarmblooded());
        }

        [Test]
        public void humansUpdateSizeTest()
        {
            Human human = new Human(180, "Test", "Test", 70);
            Assert.IsTrue(human.Size == 180);
            human.updateSize(190);
            Assert.IsTrue(human.Size == 190);
        }

        [Test]
        public void humansDontShrinkTest()
        {
            Human human = new Human(180, "Test", "Test", 70);
            var except = Assert.Throws<ArgumentOutOfRangeException>(() => human.updateSize(100));
            Assert.That(except.ParamName, Is.EqualTo("Humans don't shrink in this abstraction! Your size 100 is smaller than current size 180"));
        }

        [Test]
        public void lizardUpdateSizeTest()
        {
            Lizard lizard = new Lizard(10, 0.1M);
            Assert.IsTrue(lizard.getSize() == 10);
            lizard.updateSize(15);
            Assert.IsTrue(lizard.getSize() == 15);
        }

        [Test]
        public void lizardsDontShrinkTest()
        {
            Lizard lizard = new Lizard(10, 0.1M);
            var except = Assert.Throws<ArgumentOutOfRangeException>(() => lizard.updateSize(9));
            Assert.That(except.ParamName, Is.EqualTo("Lizards don't shrink in this abstraction! Your size 9 is smaller than current size 10"));
        }

        [Test]
        public void humanToStringTest()
        {
            Human human = new Human(180, "Test", "Test", 70);
            Assert.That(human.ToString(), Is.EqualTo("180, Test, Test, 70, True"));
        }

        [Test]
        public void lizardToStringTest()
        {
            Lizard lizard = new Lizard(10, 0.1M);
            Assert.That(lizard.ToString(), Is.EqualTo("10, 0,1, False"));
        }
    }
}
