using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Libarary
{
    public class Rectangle
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public double Perimeter()
        {
            return 2 * (this.Lenght + this.Width);
        }
        public double Area()
        {
            return this.Lenght * this.Width;
        }
    }
}
