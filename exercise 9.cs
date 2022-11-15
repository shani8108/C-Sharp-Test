using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{

    //Answer 9 continue on the example from Answer 7
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalcArea()
        {
            return Radius * Radius * 3.14;
        }
    }
    public class Triangular : IShape
    {
        public double Side { get; set; }
        public double BaseOfTriangular { get; set; }
        public Triangular(double side, double baseOfTriangular)
        {
            Side = side;
            BaseOfTriangular = baseOfTriangular;
        }
        public double CalcArea()
        {
            return Side * BaseOfTriangular / 2;
        }
    }

    internal class exercise_9
    {
        public void Run()
        {
            IShape shape1 = new Circle(6);
            IShape shape2 = new Square(8);
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(shape1);
            shapeList.Add(shape2);
            shapeList.Add(new Triangular(4,5));
            double sum = 0;
            foreach (var shape in shapeList)
            {
                sum+=shape.CalcArea();
            }
            Console.WriteLine(sum);
        }
    }
}
