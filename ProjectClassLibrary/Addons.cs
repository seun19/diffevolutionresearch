using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.IO;

namespace ProjectClassLibrary
{
    public static class Addons
    {

        public static Vector SubtractVectors(Vector vector1, Vector vector2)
        {
            //Subtract Vector2 from Vector1
            
            //Vector dimension
            int dimension1 = vector1.dimension;
            Vector subValue = new Vector(dimension1);
            for (int i = 0; i < dimension1; i++)
            {
                subValue.valueAtPosition[i] = vector1.valueAtPosition[i] - vector2.valueAtPosition[i];

            }

            return subValue;
        } // End SubtractVectors

        public static Vector AddVectors(Vector vector1, Vector vector2)
        {
            //Subtract Vector2 from Vector1

            //Vector dimension
            int dimension1 = vector1.dimension;
            Vector addValue = new Vector(dimension1);
            for (int i = 0; i < dimension1; i++)
            {
                addValue.valueAtPosition[i] = vector1.valueAtPosition[i] + vector2.valueAtPosition[i];

            }

            return addValue;
        } // End AddVectors

        public static int[] GenerateRandomInt(int exclude, int intRange)
        {
            //Generate Three random positive Integers with this method
            int[] randomInt = new int[3];
            Random rand = new Random();
            // Generate First number
            randomInt[0] = rand.Next(0, intRange);
            Thread.Sleep(10);
            if (randomInt[0] == exclude)
            {
                while (randomInt[0] == exclude) { randomInt[0] = rand.Next(0, intRange); }
            }
            // Second number
            randomInt[1] = rand.Next(0, intRange);
            Thread.Sleep(10);
            if (randomInt[1] == exclude || randomInt[1] == randomInt[0])
            {
                while (randomInt[1] == exclude || randomInt[1] == randomInt[0]) { randomInt[1] = rand.Next(0, intRange); }
            }
            
            // Third number
            randomInt[2] = rand.Next(0, intRange);
            Thread.Sleep(10);
            if (randomInt[2] == exclude || randomInt[2] == randomInt[0] || randomInt[2] == randomInt[1])
            {
                while (randomInt[2] == exclude || randomInt[2] == randomInt[0] || randomInt[2] == randomInt[1]) { randomInt[2] = rand.Next(0, intRange); }
            }

            return randomInt;

        } // End Method

        public static int[] GenerateTwoRandomInt(int exclude, int intRange)
        {
            //Generate Two random positive Integers with this method
            int[] randomInt = new int[2];
            Random rand = new Random();
            // Generate First number
            randomInt[0] = rand.Next(0, intRange);
            Thread.Sleep(10);
            if (randomInt[0] == exclude)
            {
                while (randomInt[0] == exclude) { randomInt[0] = rand.Next(0, intRange); }
            }
            // Second number
            randomInt[1] = rand.Next(0, intRange);
            Thread.Sleep(10);
            if (randomInt[1] == exclude || randomInt[1] == randomInt[0])
            {
                while (randomInt[1] == exclude || randomInt[1] == randomInt[0]) { randomInt[1] = rand.Next(0, intRange); }
            }

            return randomInt;
        } // End 

        public static Vector ScaleVector(double scalingFactor, Vector vector)
        {
            int dim = vector.dimension;
            Vector scaledVector = new Vector(dim);

            for(int i = 0; i < dim; i++)
            {
                scaledVector.valueAtPosition[i] = scalingFactor * vector.valueAtPosition[i];
            }// End for

            return scaledVector;
        }// End Scaled Vector Method

        public static Vector[] GeneratePopulation(int dimension , int popSize)
        {

            // Array of objects
            Vector[] population = new Vector[popSize];

            //Random number generator
            Random rand = new Random();
            double randNum;

            for (int p = 0; p < popSize; p++)
            {
                //Initialise each vector
                population[p] = new Vector(dimension);

                for (int k = 0; k < dimension; k++)
                {
                    randNum = rand.NextDouble();
                    population[p].valueAtPosition[k] = randNum;
                    Thread.Sleep(10);
                    //System.Console.WriteLine(randNum);
                }

            }// End for


            return population;
        }

        public static Vector[] GeneratePopulation(int dimension, int popSize, double lBound, double uBound)
        {
            //Population with lower and upper bound defined
            // Array of objects
            Vector[] population = new Vector[popSize];

            //Random number generator
            Random rand = new Random();
            double lowerUpperBound;
            double randNum;

            for (int p = 0; p < popSize; p++)
            {
                //Initialise each vector
                population[p] = new Vector(dimension);

                for (int k = 0; k < dimension; k++)
                {
                    lowerUpperBound = rand.NextDouble();
                    Thread.Sleep(5);
                    if(lowerUpperBound <= 0.5)
                    {
                        randNum = rand.NextDouble() * lBound;
                        population[p].valueAtPosition[k] = randNum;
                        Thread.Sleep(10);
                    }
                    else
                    {
                        randNum = rand.NextDouble() * uBound;
                        population[p].valueAtPosition[k] = randNum;
                        Thread.Sleep(10);
                    }
                    
                    //System.Console.WriteLine(randNum);
                }

            }// End for


            return population;
        }        

        public static double[] CalculateFitness(Vector[] vectorPopultion, string functionName = "Rastrigin")
        {
            //Rastrigin,Ackley
            int popSize = vectorPopultion.Length;  // Size of array
            double[] fitnessValue = new double[popSize];           

            if(functionName == "Rastrigin")
            {
                for (int i = 0; i < popSize; i++)
                {
                    fitnessValue[i] = TestFunction.Rastrigin(vectorPopultion[i]);
                }
            }// End if

            else if(functionName == "Ackley")
            {
                for (int i = 0; i < popSize; i++)
                {
                    fitnessValue[i] = TestFunction.Ackley(vectorPopultion[i]);
                }
            }// End else if

            else if (functionName == "Griewank")
            {
                for (int i = 0; i < popSize; i++)
                {
                    fitnessValue[i] = TestFunction.Griewank(vectorPopultion[i]);
                }
            }// End else if

            else if (functionName =="Rosenbrock")
            {
                for (int i = 0; i < popSize; i++)
                {
                    fitnessValue[i] = TestFunction.Rosenbrock(vectorPopultion[i]);
                }
            }// End else if

            else if (functionName == "Sphere")
            {
                for (int i = 0; i < popSize; i++)
                {
                    fitnessValue[i] = TestFunction.Sphere(vectorPopultion[i]);
                }
            }//End else if




            return fitnessValue;
        }// End CalculateFitness

        public static int GetBestVectorIndex(double[] fitnessValues, double bestFitness)
        {
            int bestIndex = -1;
            for(int i = 0; i<fitnessValues.Length; i++)
            {
                if(fitnessValues[i] == bestFitness)
                {
                    bestIndex = i;
                    break;
                }
                    
            }
            return bestIndex;
        }

        public static void PrintVectorsToCmd(Vector[] vectorPopulation)
        {
            //Print the initial population of vectors            
            foreach (Vector vector in vectorPopulation)
            {
                foreach (double value in vector.valueAtPosition)
                {
                    System.Console.Write(" " + value + ",");
                }

                System.Console.WriteLine();
            }// End foreach

        }

        public static void PrintVectorsToFile(Vector[] vectorPopulation)
        {

            //Print the initial population of vectors to File  
            StreamWriter sw = new StreamWriter("C:\\PythonScripts\\LiveData\\csharpdata.txt", false);
            foreach (Vector vector in vectorPopulation)
            {
                for(int i = 0; i < vector.valueAtPosition.Length; i++)
                {
                    if( i == vector.valueAtPosition.Length - 1)
                    {
                        sw.WriteLine(vector.valueAtPosition[i]);
                    }
                    else
                    {
                        sw.Write(vector.valueAtPosition[i] + ",");
                    }
                }//End for loop


            }// End foreach
            sw.Close();
            //Thread.Sleep(1000);

        }// End PrintVectorToFile method

        public static void PrintScaleToFile(double upperBound)
        {

            //Print the required scale to File  
            StreamWriter sw = new StreamWriter("C:\\PythonScripts\\LiveData\\csharpscale.txt", false);          
            sw.WriteLine(upperBound);
                    
            sw.Close();
            //Thread.Sleep(1000);

        }// End PrintScaleToFile method

        public static void PrintFitnessToCmd(double[] fitnessValue)
        {
            foreach (double value in fitnessValue)
                Console.WriteLine(value);
        }

    }// End Class

}// End Namespace
