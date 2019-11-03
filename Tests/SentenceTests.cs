using System.Linq;
using NUnit.Framework;
using SolidabisChallenge;

namespace Tests
{
    public class SentenceTests
    {
        private Sentence _sut;

        [Test]
        public void WordsAreSplitAndTurnedToLowerCase()
        {
            _sut = new Sentence("Yws� xood em��je ef��oo� xsyow� vszyw�wm ��ssddodes gf���oo� zo�aoo�wooeeo.");

            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(9));
            Assert.IsTrue(_sut.DecipheredWords.Contains("yws�"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("xood"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("em��je"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ef��oo�"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("xsyow�"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("vszyw�wm"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("��ssddodes"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("gf���oo�"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("zo�aoo�wooeeo"));
        }

        [Test]
        public void DecipheringSentencesMovesCharactersOneStepForwardInAlphabet()
        {
            _sut = new Sentence("Ab cd.");

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("bc de."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("bc"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("de"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("cd ef."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("cd"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ef"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("de fg."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("de"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("fg"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("ef gh."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ef"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("gh"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("fg hi."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("fg"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("hi"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("gh ij."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("gh"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ij"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("hi jk."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("hi"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("jk"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("ij kl."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ij"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("kl"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("jk lm."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("jk"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("lm"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("kl mn."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("kl"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("mn"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("lm no."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("lm"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("no"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("mn op."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("mn"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("op"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("no pq."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("no"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("pq"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("op qr."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("op"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("qr"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("pq rs."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("pq"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("rs"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("qr st."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("qr"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("st"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("rs tu."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("rs"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("tu"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("st uv."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("st"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("uv"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("tu vw."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("tu"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("vw"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("uv wx."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("uv"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("wx"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("vw xy."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("vw"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("xy"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("wx yz."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("wx"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("yz"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("xy z�."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("xy"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("z�"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("yz ��."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("yz"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("��"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("z� ��."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("z�"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("��"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("�� �a."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("��"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("�a"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("�� ab."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("��"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("ab"));

            Assert.IsTrue(_sut.TryCreatingNextDecipheredSentence());
            Assert.That(_sut.DecipheredSentence, Is.EqualTo("�a bc."));
            Assert.That(_sut.DecipheredWords.Count(), Is.EqualTo(2));
            Assert.IsTrue(_sut.DecipheredWords.Contains("�a"));
            Assert.IsTrue(_sut.DecipheredWords.Contains("bc"));

            Assert.IsFalse(_sut.TryCreatingNextDecipheredSentence());
        }
    }
}