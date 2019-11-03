using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class SingleWordVowelAnalyzerTests
    {
        private SingleWordVowelAnalyzer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SingleWordVowelAnalyzer();
        }

        [Test]
        public void ÄÖOrYCannotBeInTheSameWordWithAOOrU()
        {
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("säha")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("sahä")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("syo")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("suö")));

            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("saha")));
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("syö")));
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("suo")));
        }
    }
}
