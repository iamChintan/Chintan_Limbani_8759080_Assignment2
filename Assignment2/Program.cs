using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Initiate();
            Console.ReadKey();
        }

        private void Initiate()
        {
            int lengthRectangle;
            int widthRectangle;
            int heightRectangle;
            int menuRectangle;

            lengthRectangle = InputlengthRectangle();
            widthRectangle = InputwidthRectangle();
            heightRectangle = InputheightRectangle();

            Rectangle rectangleInstance = new Rectangle(lengthRectangle, widthRectangle, heightRectangle);

        optionMenu:
            string choosenMenuString;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Height");
                Console.WriteLine("6. Change Rectangle Height");
                Console.WriteLine("7. Get Rectangle Volume");
                Console.WriteLine("8. Exit");
                choosenMenuString = Console.ReadLine();
                Console.WriteLine();
            }
            while (!(int.TryParse(choosenMenuString, out menuRectangle) && ((menuRectangle > 0) && (menuRectangle < 9))));



            switch (menuRectangle)
            {
                case 1:
                    Console.WriteLine(rectangleInstance.GetlengthRectangle());
                    break;
                case 2:
                    rectangleInstance.SetlengthRectangle(InputlengthRectangle());
                    break;
                case 3:
                    Console.WriteLine(rectangleInstance.GetwidthRectangle());
                    break;
                case 4:
                    rectangleInstance.SetwidthRectangle(InputwidthRectangle());
                    break;
                case 5:
                    Console.WriteLine(rectangleInstance.GetheightRectangle());
                    break;
                case 6:
                    rectangleInstance.SetheightRectangle(InputheightRectangle());
                    break;
                case 7:
                    Console.WriteLine(rectangleInstance.GetVolume());
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }

            goto optionMenu;

        }

        int InputlengthRectangle()
        {
            int lengthRectangleValid;
            bool flag = false;
            string lengthRectangleString;
            do
            {
                Console.Write("Please enter length of the Rectangle: ");
                lengthRectangleString = Console.ReadLine();
                flag = (int.TryParse(lengthRectangleString, out lengthRectangleValid) && (lengthRectangleValid > 0));
                if (!flag)
                {
                    Console.WriteLine("Length of the Rectangle should be atleast zero and more.");
                }
            }
            while (!flag);

            return lengthRectangleValid;
        }

        int InputwidthRectangle()
        {
            int widthRectangleValid;
            bool flag = false;
            string widthRectangleString;
            do
            {
                Console.Write("Please enter width of the Rectangle: ");
                widthRectangleString = Console.ReadLine();
                flag = (int.TryParse(widthRectangleString, out widthRectangleValid) && (widthRectangleValid > 0));
                if (!flag)
                {
                    Console.WriteLine("Width of the Rectangle should be atleast zero and more.");
                }
            }
            while (!flag);

            return widthRectangleValid;
        }

        int InputheightRectangle()
        {
            int heightRectangleValid;
            bool flag = false;
            string heightRectangleString;
            do
            {
                Console.Write("Please enter heightRectangle: ");
                heightRectangleString = Console.ReadLine();
                flag = (int.TryParse(heightRectangleString, out heightRectangleValid) && (heightRectangleValid > 0));
                if (!flag)
                {
                    Console.WriteLine("Height of the Rectangle should be atleast zero and more.");
                }
            }
            while (!flag);

            return heightRectangleValid;
        }
    }
}
