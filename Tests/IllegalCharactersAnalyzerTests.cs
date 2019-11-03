using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class IllegalCharactersAnalyzerTests
    {
        private IllegalCharactersAnalyzer _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new IllegalCharactersAnalyzer();
        }

        [Test]
        public void IllegalCharacterX()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("Pikseleitä paljon")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("Pixeleitä paljon")));
        }

        [Test]
        public void IllegalCharacterÅ()
        {
            Assert.IsTrue(_sut.CanBeFinnish(new Sentence("Turku")));
            Assert.IsFalse(_sut.CanBeFinnish(new Sentence("Åbo")));
        }
    }
}
