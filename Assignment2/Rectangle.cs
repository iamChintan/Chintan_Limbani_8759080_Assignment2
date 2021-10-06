using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int lengthRectangle;
        private int widthRectangle;
        private int heightRectangle;

        public Rectangle()
        {
            lengthRectangle = 1;
            widthRectangle = 1;
            heightRectangle = 1;
        }

        public Rectangle(int lengthRectangle, int widthRectangle, int heightRectangle)
        {
            this.lengthRectangle = lengthRectangle;
            this.widthRectangle = widthRectangle;
            this.heightRectangle = heightRectangle;
        }

        public int GetlengthRectangle()
        {
            return this.lengthRectangle;
        }

        public int SetlengthRectangle(int lengthRectangle)
        {
            this.lengthRectangle = lengthRectangle;
            return this.lengthRectangle;
        }

        public int GetwidthRectangle()
        {
            return this.widthRectangle;
        }

        public int SetwidthRectangle(int widthRectangle)
        {
            this.widthRectangle = widthRectangle;
            return this.widthRectangle;
        }

        public int GetheightRectangle()
        {
            return this.heightRectangle;
        }

        public int SetheightRectangle(int heightRectangle)
        {
            this.heightRectangle = heightRectangle;
            return this.heightRectangle;
        }

        public int GetVolume()
        {
            return this.lengthRectangle * this.widthRectangle * this.heightRectangle;
        }
    }
}
