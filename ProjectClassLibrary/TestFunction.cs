using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary
{
    public static class TestFunction
    {
        //Rastrigin Function
        public static double Rastrigin(Vector vector)
        {
            int dim = vector.dimension;
            double sum = 0.0;
            for (int i = 0; i < dim; i++)
            {
                sum += vector.valueAtPosition[i] * vector.valueAtPosition[i] - 10.0 * Math.Cos(2.0 * Math.PI * vector.valueAtPosition[i]) + 10.0;
            }
            return sum;

        }// End Rastrigin

        //Ackley Function
        public static double Ackley(Vector vector)
        {
            int dim = vector.dimension;
            double sum = 0.0;
            double sum1 = 0.0;
            double sum2;
            for (int i = 0; i < dim; i++)
            {
                sum += Math.Pow(vector.valueAtPosition[i], 2);
                sum1 += Math.Cos(2.0 * Math.PI * vector.valueAtPosition[i]);
            }

            sum2 = -20.0 * Math.Exp(-0.2 * Math.Sqrt(sum / dim)) - Math.Exp(sum1 / dim) + 20.0 + Math.E;
            return sum2;

        }

        //Griewank Function
        public static double Griewank(Vector vector)
        {
            int dim = vector.dimension;
            double sum = 0.0;
            double product = 1.0;

            for(int i = 0; i < dim; i++)
            {
                sum += Math.Pow(vector.valueAtPosition[i], 2);
                product *= Math.Cos(vector.valueAtPosition[i] / Math.Sqrt(Convert.ToDouble(i) + 1.0));
            }
            sum = (sum / 4000.0) - product + 1.0;
            
            return sum;
        }// End Griewank Function

        //Rosenbrock
        public static double Rosenbrock(Vector vector)
        {
            int dim = vector.dimension;
            double sum = 0.0;
            double a = 0.0;
            double b = 0.0;

            for(int i = 0; i < dim - 1; i++)
            {
                a = vector.valueAtPosition[i] * vector.valueAtPosition[i] - vector.valueAtPosition[i + 1];
                b = 1.0 - vector.valueAtPosition[i];
                sum += 100.0 * a * a + b * b;                
            }
            return sum;

        }// End Rosenbrock Method

        //Sphere Function
        public static double Sphere(Vector vector)
        {
            int dim = vector.dimension;
            double sum = 0.0;
            for (int i = 0; i < dim; i++)
            {                
                    sum += Math.Pow(vector.valueAtPosition[i], 2);                
            }
            return sum;
        }

        //A Differentiable Function



    }// End Testfunction Class

}// End Namespace
