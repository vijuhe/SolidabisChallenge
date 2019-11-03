using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class ConsecutiveConsonantAnalyzerTests
    {
        private ConsecutiveConsonantAnalyzer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new ConsecutiveConsonantAnalyzer();
        }

        [Test]
        public void FourConsecutiveConsonantsIsNotFinnish()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("possu juoksee kentällä.")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("possu jhfgayhi kentällä.")));
        }

        [Test]
        public void ThreeDifferentConsecutiveConsonantsIsNotFinnish()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("Henriksson")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("Hendriksson")));
        }

        [Test]
        public void OnlyConsonantsIsNotFinnish()
        {
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("xD")));
        }

        [Test]
        public void CharacterJCannotBeFollowedByAnotherConsonant()
        {
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("luojka")));
        }

        [Test]
        public void TwoConsonantsInTheBeginningIsNotFinnish()
        {
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("lluoja")));
        }

        [Test]
        public void TwoConsonantsInTheEndIsNotFinnish()
        {
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("suomalainenn")));
        }
    }
}
