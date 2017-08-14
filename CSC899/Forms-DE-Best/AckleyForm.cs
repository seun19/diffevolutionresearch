using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using ProjectClassLibrary;

namespace CSC899.Forms_DE_Best
{
    public partial class AckleyForm : Form
    {
        // Declare variables to be supplied
        int numberOfRuns = 1;
        int iterations = 1000;
        int dim = 2;
        int popSize = 20;
        double crossOverProbability = 0.3;
        double scalingFactor = 0.5;

        //Declare Variables lower and upper bound for rastrigin to be supplied
        double lowerBound = -30.0;
        double upperBound = 30.0;

        //Declare Thread Variable
        ThreadStart testAckleyRef;
        Thread testAckleyThread;

        public AckleyForm()
        {
            InitializeComponent();
            
        }

        //Events
        //private void RastriginForm_Load(object sender, EventArgs e)
        //{
            
        //}
        private void AckleyForm_Load(object sender, EventArgs e)
        {
            //Non changeable Variables
            txtIterations.Text = Convert.ToString(iterations);
            txtDimension.Text = Convert.ToString(dim);
            txtPopulationSize.Text = Convert.ToString(popSize);
            txtLowerBound.Text = Convert.ToString(lowerBound);
            txtUpperBound.Text = Convert.ToString(upperBound);
            txtNumOfRuns.Text = Convert.ToString(numberOfRuns);
            //Changeable Variables
            txtScalingFactor.Text = Convert.ToString(scalingFactor);
            txtCrossOver.Text = Convert.ToString(crossOverProbability);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start the optimization thread
            testAckleyRef = new ThreadStart(TestAckley);
            testAckleyThread = new Thread(testAckleyRef);
            testAckleyThread.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //Pause the optimization thread
            testAckleyThread.Suspend();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            //Resume the optimization thread
            testAckleyThread.Resume();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            //Abort the optimization thread
            testAckleyThread.Abort();
        }

        private void btnIterations_Click(object sender, EventArgs e)
        {
            iterations = Convert.ToInt32(txtIterations.Text);
        }

        private void btnDimension_Click(object sender, EventArgs e)
        {
            dim = Convert.ToInt32(txtDimension.Text);
        }

        private void btnPopulationSize_Click(object sender, EventArgs e)
        {
            popSize = Convert.ToInt32(txtPopulationSize.Text);
        }

        private void btnLowerBound_Click(object sender, EventArgs e)
        {
            lowerBound = Convert.ToDouble(txtLowerBound.Text);
        }

        private void btnUpperBound_Click(object sender, EventArgs e)
        {
            upperBound = Convert.ToDouble(txtUpperBound.Text);
        }

        private void btnCrossOver_Click(object sender, EventArgs e)
        {
            crossOverProbability = Convert.ToDouble(txtCrossOver.Text);
        }

        private void btnScaleFactor_Click(object sender, EventArgs e)
        {
            scalingFactor = Convert.ToDouble(txtScalingFactor.Text);
        }

        private void btnNumOfRuns_Click(object sender, EventArgs e)
        {
            numberOfRuns = Convert.ToInt32(txtNumOfRuns.Text);
        }

        //Method
        //Method to run as Thread
        public void TestAckley()
        {
            // Declare variable not to be supplied
            double bestSolutionValue;
            int bestVectorIndex;
            double newScale;
            // Declare Variables - Arrays to keep vector population
            Vector[] popOfVectors;  //population of vectors
            Vector[] trialVectors;  //trial vectors
            Vector[] crossedVectors;  // crossed vectors for next generation based on fitness
            Vector[] selectedVectors; // selected vectors for next generation

            // Declare Variables to store fitness
            double[] popOfVectorFitness;
            double[] crossedVectorFitness = new double[popSize];

            //Write Scale to file if necessary-----------------------------------
            Addons.PrintScaleToFile(upperBound);

            //number of runs
            int runs = 1;
            while (runs <= numberOfRuns)
            {

                //  1--Initial Population Generation
                // Generate initial population of vectors
                Console.WriteLine("Generating Initial Population");
                popOfVectors = Addons.GeneratePopulation(dim, popSize, lowerBound, upperBound);

                //Print the initial population of vectors to cmd
                Addons.PrintVectorsToCmd(popOfVectors);

                // 1.1-- Check fitness of population
                popOfVectorFitness = Addons.CalculateFitness(popOfVectors, "Ackley");
                // Print fitness
                Addons.PrintFitnessToCmd(popOfVectorFitness);

                // Best solution found
                bestSolutionValue = popOfVectorFitness.Min();
                bestVectorIndex = Addons.GetBestVectorIndex(popOfVectorFitness, bestSolutionValue);
                Console.WriteLine("Best Solution Found :" + bestSolutionValue);

                for (int i = 0; i < iterations; i++)
                {

                    // 2-- Mutation DE/Best
                    // Apply mutation by Generating Trial Vectors
                    //Console.WriteLine("Generating Trial Vectors");
                    trialVectors = Operators.Mutation(popOfVectors, bestVectorIndex, scalingFactor);

                    //Print the trial vectors population to cmd
                    //Addons.PrintVectorsToCmd(trialVectors);

                    // 3-- CrossOver
                    // Apply cross over using the initial population and the trial vector
                    //Console.WriteLine("Generating Crossed Vectors");
                    crossedVectors = Operators.CrossOver(popOfVectors, trialVectors, dim, crossOverProbability);

                    //Print the Crossed vectors population to cmd
                    //Addons.PrintVectorsToCmd(crossedVectors);

                    // 3.1-- Check fitness of population
                    crossedVectorFitness = Addons.CalculateFitness(crossedVectors, "Ackley");
                    // Print fitness
                    //Addons.PrintFitnessToCmd(crossedVectorFitness);

                    // 4-- Selection
                    // Apply selection for vectors that will move to next generation
                    selectedVectors = Operators.SelectionForNextGenation(popOfVectors, crossedVectors, popOfVectorFitness, crossedVectorFitness);

                    //Print Selected Values
                    //Console.WriteLine("Selected Values for next Generation");
                    //Addons.PrintVectorsToCmd(selectedVectors);

                    //5-- Copy selected vectors into initial vector population
                    //Console.WriteLine("Generating Replaced Initial Population");
                    selectedVectors.CopyTo(popOfVectors, 0);
                    //Addon.GetScale Get new scale based on solution found
                    newScale = Addons.GetScale(popOfVectors);
                    //Addon Print scale to file
                    Addons.PrintScaleToFile(newScale);
                    //Addons.PrintVectorsToCmd(popOfVectors);
                    Addons.PrintVectorsToFile(popOfVectors);

                    //5.1-- Get fitness of New population of vectors(the new population)
                    popOfVectorFitness = Addons.CalculateFitness(popOfVectors, "Ackley");

                    //5.2-- Get Best solution found
                    bestSolutionValue = popOfVectorFitness.Min();
                    bestVectorIndex = Addons.GetBestVectorIndex(popOfVectorFitness, bestSolutionValue);
                    Console.WriteLine("Iteration" + i + "  Best Vector Index=" + bestVectorIndex + "   Best Solution Found :" + bestSolutionValue);

                }// End for loop

                //Print all fitness values
                Console.WriteLine("\n\n Printing all Fitness Value when done");
                Addons.PrintVectorsToCmd(popOfVectors);
                Addons.PrintFitnessToCmd(popOfVectorFitness);

                //Printing best values to text file
                Addons.PrintObjectiveValueToFile(runs, bestSolutionValue);
                runs++; // increment the number of runs

            }//End while -number of runs

            
        }// End Method

        
    }// End Class
}
