using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StructuralDesignPatterns.Adapter
{
    class WithOutAdapter
    {
        public static void Run()
        {
            int x1 = 10;
            int x2 = 10;
            int y1 = 30;
            int y2 = 30;
            int width = x2 - x1;
            int height = y2 - y1;

            List<IShape> shapes = new List<IShape> { new Line(), new Rectangle() };
            foreach (var shape in shapes)
            {
                switch (shape.GetType().Name)
                {
                    case "Line":
                        shape.Draw(x1, y1, x2, y2);
                        break;
                    case "Rectangle":
                        shape.Draw(x1, x2, width, height);
                        break;
                }
            }
        }
    }
}
