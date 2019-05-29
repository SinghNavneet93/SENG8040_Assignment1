using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment1;
using NUnit.Framework;


namespace SENG8040_Assignment1_Test
{
    [TextFixture]

    class SENG8040_Assignment1_Test
    {
        [Test]
        public void GetLength_Input65_expectedLengthEquals65()
        {

            //Arrange
            int length = 65;
            int width = 45;

            int expectedLength = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actuallength = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(length, actuallength);
        }
    }
}


