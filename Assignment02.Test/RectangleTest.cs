using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace Assignment02.Test
{
   
[TestFixture]
class RectangleTest
{
        //Test Case #1
        [Test]
        public void GetlengthRectangle_16_9_97()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(16,9,97);

            //Assert
            Assert.AreEqual(rectangle.GetlengthRectangle(), 16);
        }

        //Test Case #2
        [Test]
        public void GetlengthRectangle_Neg31_8_97()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(-31,8,97);

            //Assert
            Assert.AreEqual(rectangle.GetlengthRectangle(), -31);
        }

        //Test Case #3
        [Test]
        public void GetlengthRectangle_0_0_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0,0,0);

            //Assert
            Assert.AreEqual(rectangle.GetlengthRectangle(), 0);
        }

        //Test Case #4
        [Test]
        public void SetlengthRectangle_66_67_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetlengthRectangle(66);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 66);
        }


        //Test Case #5
        [Test]
        public void SetlengthRectangle_NEG44_43_47()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetlengthRectangle(-44);

            //Assert
            Assert.AreEqual(lengthOfRectangle, -44);
        }

        //Test Case #6
        [Test]
        public void SetlengthRectangle_0_96_97()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetlengthRectangle(0);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 0);
        }

        //Test Case #7
        [Test]
        public void GetwidthRectangle_6_7_8()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(6,7,8);

            //Assert
            Assert.AreEqual(rectangle.GetwidthRectangle(), 7);
        }

        //Test Case #8
        [Test]
        public void GetwidthRectangle_0_NEG24_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0,-24,0);

            //Assert
            Assert.AreEqual(rectangle.GetwidthRectangle(), -24);
        }

        //Test Case #9
        [Test]
        public void GetwidthRectangle_0_0_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0, 0, 0);

            //Assert
            Assert.AreEqual(rectangle.GetwidthRectangle(), 0);
        }

        //Test Case #10
        [Test]
        public void SetwidthRectangle_86_77_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetwidthRectangle(77);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 77);
        }


        //Test Case #11
        [Test]
        public void SetwidthRectangle_83_NEG79_33()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetwidthRectangle(-79);

            //Assert
            Assert.AreEqual(lengthOfRectangle, -79);
        }

        //Test Case #12
        [Test]
        public void SetwidthRectangle_0_0_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetwidthRectangle(0);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 0);
        }

        //Test Case #13
        [Test]
        public void GetheightRectangle_3_4_5()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 4, 5);

            //Assert
            Assert.AreEqual(rectangle.GetheightRectangle(), 5);
        }

        //Test Case #14
        [Test]
        public void GetheightRectangle_3_9_NEG6()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 9, -6);

            //Assert
            Assert.AreEqual(rectangle.GetheightRectangle(), -6);
        }

        //Test Case #15
        [Test]
        public void GetheightRectangle_30_4_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(30, 4, 0);

            //Assert
            Assert.AreEqual(rectangle.GetheightRectangle(), 0);
        }

        //Test Case #16
        [Test]
        public void SetheightRectangle_39_42_84()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetheightRectangle(84);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 84);
        }

        //Test Case #17
        [Test]
        public void SetheightRectangle_9_2_NEG4()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetheightRectangle(-4);

            //Assert
            Assert.AreEqual(lengthOfRectangle, -4);
        }

        //Test Case #18
        [Test]
        public void SetheightRectangle_5_6_0()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            var lengthOfRectangle = rectangle.SetheightRectangle(0);

            //Assert
            Assert.AreEqual(lengthOfRectangle, 0);
        }

        //Test Case #19
        [Test]
        public void GetVolume_7_1_9()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(7, 1, 9);

            //Assert
            Assert.AreEqual(rectangle.GetVolume(), 63);
        }

        //Test Case #20
        [Test]
        public void GetVolume_NEG1_1_3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(-1, 1, 3);

            //Assert
            Assert.AreEqual(rectangle.GetVolume(), -3);
        }

        //Test Case #21
        [Test]
        public void GetVolume_0_16_NEG31()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(0, 16, 31);

            //Assert
            Assert.AreEqual(rectangle.GetVolume(), 0);
        }

    }

}
