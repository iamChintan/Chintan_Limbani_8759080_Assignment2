using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int height;

        public Rectangle()
        {
            length = 1;
            width = 1;
            height = 1;
        }

        public Rectangle(int length, int width, int height)
        {
            length = length;
            width = width;
            height = height;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int SetHeight(int height)
        {
            this.height = height;
            return this.height;
        }

        public int GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
