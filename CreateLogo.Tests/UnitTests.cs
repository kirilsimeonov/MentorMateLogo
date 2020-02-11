using CreateLogo;
using CreateLogo.Logos;
using CreateLogo.Logos.Contracts;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        public void TestIfLogoConstructorWorks()
        {
            ILogo testLogo = new MentorMateLogo(5);
        
            Assert.AreEqual("Mentor Mate",testLogo.Name);
            Assert.AreEqual(5,testLogo.Width);
        }

        [Test]
        public void TestIfIncorectDimensionsThrowsException()
        {

            Assert.That(() => new MentorMateLogo(-2), Throws.Exception);
            Assert.That(() => new MentorMateLogo(12000), Throws.Exception);
        }

        [Test]
        public void CheckIfLogoMatrixHasCorrectDimensions()
        {
            ILogo testLogo = new MentorMateLogo(5);
            char[,] testMatrix = testLogo.CreateLogoMatrix();

            Assert.AreEqual(6, testMatrix.GetLength(0));
            Assert.AreEqual(50, testMatrix.GetLength(1));
        }



    }
}