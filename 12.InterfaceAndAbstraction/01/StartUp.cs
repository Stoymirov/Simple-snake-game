using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IDrawable> figures = new List<IDrawable>();

         Circle circle = new Circle(5);
         Rectangle rectangle = new Rectangle(5, 10);

         figures.Add(circle);
         figures.Add(rectangle);
         foreach (var drawable in figures)
         {
             drawable.Draw();
         }
        }

    }
}




