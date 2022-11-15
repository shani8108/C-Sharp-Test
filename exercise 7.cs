using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{
    public interface IShape
    {
        double CalcArea();
    }
    public class Square : IShape
    {
        public double Edge { get; set; }
        public Square(double edge)
        {
            Edge = edge;
        }
        public double CalcArea()
        {
            return Edge * Edge;
        }
    }

    internal class exercise_7
    {
        public void Print(IShape shape)
        {
            Console.WriteLine(shape.CalcArea());
        }
        public void Run()
        {
            IShape shape = new Square(5);
            Print(shape);
            double area = shape.CalcArea();
        }
    }
}
