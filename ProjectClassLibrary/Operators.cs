using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProjectClassLibrary
{
    // Differencial Evolution Operators
    public static class Operators
    {
        //Basic Mutation - DE/Rand/1 Target Vector is a Random Vector, One difference vector
        //Parameter: Current population:Parent Population, Scaling Factor
        public static Vector[] Mutation(Vector[] currentPop, double scaleFactor)
        {
            int popSize = currentPop.Length;
            int dim = currentPop[0].dimension;
            Vector[] trialVectors = new Vector[popSize];

            //Genrate Trial vectors using Target and Difference Vectors
            //Random Integer for vector position 
            //Random random = new Random();
            int targetVecPos ;           
            int diffVecPos1  ;            
            int diffVecPos2 ;

            Vector diffValue;
            Vector scaledValue;
            int[] randomInt = new int[3];

            for (int t = 0; t < popSize; t++)
            {
                trialVectors[t] = new Vector(dim);
                //Generate three different unique random numbers  
                randomInt = Addons.GenerateRandomInt(t, popSize);
                targetVecPos = randomInt[0];              
                diffVecPos1 = randomInt[1];               
                diffVecPos2 = randomInt[2];

                //Console.WriteLine("t=" + t + " tarpos=" + targetVecPos + " vecpos1=" + diffVecPos1 + " vecpos2=" + diffVecPos2);
                //Compute Trial Vector
                diffValue = Addons.SubtractVectors(currentPop[diffVecPos1], currentPop[diffVecPos2]);
                scaledValue = Addons.ScaleVector(scaleFactor,diffValue);
                trialVectors[t] = Addons.AddVectors(currentPop[targetVecPos], scaledValue);

            }//End For

            //Return Trial Vectors
            return trialVectors;

        }// End Mutation Method

        //Basic Mutation - DE/Best/1 Target Vector is Best Vector
        //Parameter: Current population:Parent Population, Scaling Factor
        public static Vector[] Mutation(Vector[] currentPop, int bestVectorIndex, double scaleFactor)
        {
            int popSize = currentPop.Length;
            int dim = currentPop[0].dimension;
            Vector[] trialVectors = new Vector[popSize];

            //Genrate Trial vectors using Target and Difference Vectors
            //Random Integer for vector position 
            //Random random = new Random();
            int targetVecPos = bestVectorIndex;   // Target vector is best vector found
            int diffVecPos1;
            int diffVecPos2;

            Vector diffValue;
            Vector scaledValue;
            int[] randomInt = new int[2];

            for (int t = 0; t < popSize; t++)
            {
                trialVectors[t] = new Vector(dim);
                //Generate three different unique random numbers  
                randomInt = Addons.GenerateRandomInt(t, popSize);
                diffVecPos1 = randomInt[0];
                diffVecPos2 = randomInt[1];

                //Console.WriteLine("t=" + t + " tarpos=" + targetVecPos + " vecpos1=" + diffVecPos1 + " vecpos2=" + diffVecPos2);
                //Compute Trial Vector
                diffValue = Addons.SubtractVectors(currentPop[diffVecPos1], currentPop[diffVecPos2]);
                scaledValue = Addons.ScaleVector(scaleFactor, diffValue);
                trialVectors[t] = Addons.AddVectors(currentPop[targetVecPos], scaledValue);

            }//End For

            //Return Trial Vectors
            return trialVectors;

        }


        //Basic Mutation - DE/Rand to Best/1 
        //Parameter: Current population:Parent Population, Scaling Factor
        public static Vector[] Mutation_RandToBest(Vector[] currentPop, int bestVectorIndex, double scaleFactor)
        {
            int popSize = currentPop.Length;
            int dim = currentPop[0].dimension;
            Vector[] trialVectors = new Vector[popSize];

            //Genrate Trial vectors using Target and Difference Vectors
            //Random Integer for vector position 
            //Random random = new Random();
            int targetVecPos; 
            int diffVecPos1;
            int diffVecPos2;

            Vector diffValue, diffValue0;
            Vector scaledValue, scaledValue0;
            int[] randomInt = new int[3];

            for (int t = 0; t < popSize; t++)
            {
                trialVectors[t] = new Vector(dim);
                //Generate three different unique random numbers  
                randomInt = Addons.GenerateRandomInt(t, popSize);
                targetVecPos = randomInt[0];
                diffVecPos1 = randomInt[1];
                diffVecPos2 = randomInt[2];

                //Console.WriteLine("t=" + t + " tarpos=" + targetVecPos + " vecpos1=" + diffVecPos1 + " vecpos2=" + diffVecPos2);
                //Compute Trial Vector
                diffValue0 = Addons.SubtractVectors(currentPop[bestVectorIndex], currentPop[targetVecPos]);
                scaledValue0 = Addons.ScaleVector(scaleFactor, diffValue0);
                diffValue = Addons.SubtractVectors(currentPop[diffVecPos1], currentPop[diffVecPos2]);
                scaledValue = Addons.ScaleVector(scaleFactor, diffValue);
                trialVectors[t] = Addons.AddVectors(scaledValue0, scaledValue);
                trialVectors[t] = Addons.AddVectors(currentPop[targetVecPos], trialVectors[t]);

            }//End For

            //Return Trial Vectors
            return trialVectors;

        }

        //CrossOver with probability 
        //Parameters : parent population, trial vectors, vector dimension, crossover probability
        public static Vector[] CrossOver(Vector[] parentVectorPop, Vector[] trialVector,int dimension, double crossOverProbability)
        {
            int popSize = parentVectorPop.Length;
            Vector[] offSpringVector = new Vector[popSize];
            
            //Random number generator for probability
            Random rand = new Random();
            double randomValue;
            for(int i = 0; i < popSize; i++ )
            {
                offSpringVector[i] = new Vector(dimension);

                for(int j = 0; j < dimension; j++)
                {
                    //Get probabbility and Generate new offspring
                    randomValue = rand.NextDouble();
                    //Thread.Sleep(5);
                    if (randomValue <= crossOverProbability)
                    {
                        offSpringVector[i].valueAtPosition[j] = trialVector[i].valueAtPosition[j];
                    }
                    else
                    {
                        offSpringVector[i].valueAtPosition[j] = parentVectorPop[i].valueAtPosition[j];
                    }

                }// End second for loop

            }// End first for loop

            return offSpringVector;

        }// End CrossOver Method

        //Selection for next generation
        public static Vector[] SelectionForNextGenation(Vector[] initPopulation,Vector[] crossedPopulation,
            double[] initPopFitness,double[] crossedPopFitness)
        {
            //Variable to keep selected Vectors
            int dim = initPopulation[0].dimension;
            int popSize = initPopulation.Length;
            Vector[] selectedVectors = new Vector[popSize];
            for(int i = 0; i < popSize; i++)
            {
                selectedVectors[i] = new Vector(dim);
                if (crossedPopFitness[i] < initPopFitness[i])
                {
                    selectedVectors[i] = crossedPopulation[i];
                }// End If
                else
                {
                    selectedVectors[i] = initPopulation[i];
                }
            }//End For loop

            return selectedVectors;

        } // End Selection Method

    }//End Class

}// End NameSpace 
