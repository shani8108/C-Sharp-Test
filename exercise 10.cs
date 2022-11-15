using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{
    //Answer 10 continue on the example from answer 9 and 7
    public class Factory
    {
        public IShape BuildShape(string nameShape,int[] valuesOfShape)
        {
            switch (nameShape)
            {
                case "Square": 
                    return new Square(valuesOfShape[0]);
                case "Circle": 
                    return new Circle(valuesOfShape[0]);
                case "Triangular": 
                    return new Triangular(valuesOfShape[0],valuesOfShape[1]);
                default: 
                    return null;
            }

        }
    }
    internal class exercise_10
    {
        public void Run()
        {
            Factory factory = new Factory();
            int[] values = new int[2] {4,5};
            IShape shape1 = factory.BuildShape("Triangular",values);
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(shape1);
            IShape shape2 = factory.BuildShape("Circle", values);
            shapeList.Add(shape2);
            double sum = 0;
            foreach (var shape in shapeList)
            {
                sum += shape.CalcArea();
            }
            Console.WriteLine(sum);
        }
    }
}
