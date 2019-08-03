using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StructuralDesignPatterns.Adapter
{
    interface IShape
    {
        void Draw(int x1, int y1, int x2, int y2);
    }

    class Line : IShape
    {
        public void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Draw by (x1, x2, y1, y2)");
        }
    }

    class Rectangle : IShape
    {
        public void Draw(int x1, int y1, int width, int height)
        {
            Console.WriteLine("Draw by (x1, x2, width, height)");
        }
    }
}
