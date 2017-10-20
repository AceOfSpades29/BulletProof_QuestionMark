using Microsoft.VisualStudio.TestTools.UnitTesting;
using BulletProof_QuestionMark.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletProof_QuestionMark.Program.Tests
{
    [TestClass()]
    public class BulletProofTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "")]
        public void InValidUrlParamTest()
        {
            var sut = new BulletProof();

            sut.DoStuff(null, "product", "category");

            //Assert
            //Exception is thrown
        }

        //Implicitly implies that if the url is not null or empty no argument exception error is thrown
        //Implicitly implies that if the url  and productpath match that it doesn't fall through to categorypath logic.
        [TestMethod()]
        public void ValidUrlAndPathProductTest()
        {
            var sut = new BulletProof();

            var actual = sut.DoStuff("a product url", "a product url", "xxxx");

            Assert.AreEqual("GoogleTagManagerScripts/GtmProductDetailsView", actual);

        }
        //Implicitly implies that if the url is not null or empty no argument exception error is thrown
        //Implicitly implies that if the url  and productpath do  contain the same values that it does not fall through to categorypath if logic.
        [TestMethod()]
        public void ValidUrlAndCategoryPathTest()
        {
            var sut = new BulletProof();

            var actual = sut.DoStuff("a category url", "a product url", "a category url");

            Assert.AreEqual("GoogleTagManagerScripts/GtmCategoryDetails", actual);

        }
        //Implicitly implies that if the url is not null or empty no argument exception error is thrown
        //Implicitly implies that if the url  and productpath do not contain the same values that it does fall through to categorypath if logic.
        //Implicitly implies that if the url and categorypath do not contain the same values that it falls to the esle logic
        [TestMethod()]
        public void NoMatchSoDontDoStuff_ReturnGoogleTagManagerString()
        {
            var sut = new BulletProof();

            var actual = sut.DoStuff("a match url", "a product url", "a category url");

            Assert.AreEqual("GoogleTagManagerScripts/GtmMainScript", actual);

        }
    }
}