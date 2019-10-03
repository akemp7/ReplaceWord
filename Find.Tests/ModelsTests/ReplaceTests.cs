using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Test
{
    [TestClass]
    public class ReplaceTest
    {
        [TestMethod]

        public void FindReplace_ReplaceWord_Cat()
        {
            string userString = "Write something";
            string userWord = "something";
            string replacementWord = "cat";
            Replace newReplace = new Replace(userString, userWord, replacementWord);
            newReplace.FindReplace();
            string output = newReplace.NewPhrase;
            Assert.AreEqual("Write cat", output);
        }
    }
}