using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StructuralDesignPatterns.Adapter
{
    class WithAdapter
    {
        public static void Run()
        {
            int x1 = 10;
            int x2 = 10;
            int y1 = 30;
            int y2 = 30;
            int width = x2 - x1;
            int height = y2 - y1;

            List<IShape> shapes = new List<IShape> { new Line(), new RectangleAdapter(new Rectangle()) };
            foreach (var shape in shapes)
            {
                shape.Draw(x1, y1, x2, y2);
            }
        }
    }

    class RectangleAdapter : IShape
    {
        public Rectangle Rectangle { get; set; }

        public RectangleAdapter(Rectangle rectangle)
        {
            Rectangle = rectangle;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            int width = x2 - x1;
            int height = y2 - y1;

            Rectangle.Draw(x1, y1, width, height);
        }
    }
}
