using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1_3_варік_
{
    internal class Rectangle
    {
        protected double a;
        protected double b;

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return a;
                    case 1: return b;
                    default: throw new IndexOutOfRangeException("The index must be 0 or 1");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: a = value; break;
                    case 1: b = value; break;
                    default: throw new IndexOutOfRangeException("The index must be 0 or 1");
                }
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter the sides of the ricrangle");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0 )
                throw new ArgumentException("Both sides must be greater than zero");
        }
        public void Output()
        {
            if (a == b)
                Console.WriteLine(" It's not rictangle.It's square");
            else
                Console.WriteLine(" Okey, it's rectangle");
            Console.WriteLine($"Perimenter = {Perimetr()}");
            Console.WriteLine($"The area = {TheArea()}");
        }
        protected bool IsRectangle(double a, double b)
        {
            if (a == b)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public double Perimetr()
        {
                return (this.a + this.b) * 2;
        }
        public double TheArea()
        {
                return (this.a * this.b);
        }
    }
}
