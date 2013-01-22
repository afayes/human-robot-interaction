using System;
using System.Collections.Generic;
using System.IO;
using AForge.Neuro.Learning;
using AForge.Neuro;
using System.Threading;
using System.Windows.Forms;

namespace neuralNetwork
{
    public class NeuralNetwork
    {
        /*
         *  This class creates the neural network for speech tone classification 
         *  and does operations for training the network  
         * 
         */
        
        // declaraation of variables
        private double[][] learningData;
        private double[][] input;
        private double[][] output;

        private double[] angryType = { 1, 0, 0, 0 };
        private double[] happyType = { 0, 1, 0, 0 };
        private double[] sadType = { 0, 0, 1, 0 };
        private double[] neutralType = { 0, 0, 0, 1 };

        private int sampleCount = 0;
        private int normaliser = 10000;

        private ActivationNetwork network;
        private BackPropagationLearning teacher;

        private double learningRate = 0.1;
        private double momentum = 0;
        private double sigmoidAV = 2;
        private double iteration = 1000;
        private Boolean randomiseInputData = false;
        private Boolean randomMomentum = true;

        private Label outputErrorComponent;

        private double error;


        // constructor
        public NeuralNetwork()
        {
            defaultSettings();
            loadData();
            prepareInputOuputData();
            learn();
        }


        // load training data from file
        public void loadData()
        {
            learningData = new double[1000][];

            double[] sampleType = new double[4];

            double minPerSecond = 0;
            double maxPerSecond = 0;
            double minAverage = 0;
            double maxAverage = 0;

            sampleCount = 0;


            try
            {
                StreamReader input = new StreamReader("learningData.txt");
                String textLine;
                while ((textLine = input.ReadLine()) != null)
                {
                    if (textLine == "Angry/Loud samples")
                    {
                        sampleType = angryType;
                    }

                    else if (textLine == "Happy/Medium samples")
                    {
                        sampleType = happyType;
                    }

                    else if (textLine == "Sad/Low Samples")
                    {
                        sampleType = sadType;
                    }

                    else if (textLine == "Neutral/Silent samples")
                    {
                        sampleType = neutralType;
                    }

                    else if (textLine.Contains("min Per second"))   // min Per second ,  max per second,  min avrage,  max average
                    {
                        int indexOfEqualsChar = textLine.IndexOf("=");
                        minPerSecond = double.Parse(textLine.Substring(indexOfEqualsChar + 2).Trim());
                    }

                    else if (textLine.Contains("max per second"))
                    {
                        int indexOfEqualsChar = textLine.IndexOf("=");
                        maxPerSecond = double.Parse(textLine.Substring(indexOfEqualsChar + 2).Trim());
                    }

                    else if (textLine.Contains("min average"))
                    {
                        int indexOfEqualsChar = textLine.IndexOf("=");
                        minAverage = double.Parse(textLine.Substring(indexOfEqualsChar + 2).Trim());
                    }

                    else if (textLine.Contains("max average"))
                    {
                        int indexOfEqualsChar = textLine.IndexOf("=");
                        maxAverage = double.Parse(textLine.Substring(indexOfEqualsChar + 2).Trim());
                        double[] tempArray = { minPerSecond, maxPerSecond, minAverage, maxAverage, sampleType[0], sampleType[1], sampleType[2], sampleType[3] };
                        learningData[sampleCount] = tempArray;
                        sampleCount++;
                    }


                }


            }
            catch (Exception e)
            {
                Console.WriteLine("error while trying to read file:");
                Console.WriteLine(e.Message);
            }
        }

        // put training data into input/oupt vectors - randomise or keep order of data depending on configuration  
        public void prepareInputOuputData()
        {
            if (randomiseInputData)
            {
                randomize(learningData);
            }

            input = new double[sampleCount][];
            output = new double[sampleCount][];

            for (int i = 0; i < sampleCount; i++)
            {
                double[] tempData = learningData[i];

                double[] tempInput = { tempData[0] / normaliser, tempData[1] / normaliser, tempData[2] / normaliser, tempData[3] / normaliser };
                input[i] = tempInput;

                double[] tempOutput = { tempData[4], tempData[5], tempData[6], tempData[7] };
                output[i] = tempOutput;
            }
        }

        // teach the network 
        public void learn()
        {
            network = new ActivationNetwork(new SigmoidFunction(sigmoidAV), 4, 5, 4);
            teacher = new BackPropagationLearning(network);

            teacher.LearningRate = learningRate;
            teacher.Momentum = momentum;
            error = 0;

            Random randomG = new Random();

            for (int i = 0; i < iteration; i++)
            {
                if (randomMomentum)
                {
                    double random = (randomG.NextDouble() * 0.3) + 0.5;
                    teacher.Momentum = random;
                }
                error = teacher.RunEpoch(input, output) / sampleCount;
                if(outputErrorComponent != null)
                {
                    outputErrorComponent.Text = "Neural network error is : " + error;
                }
            }

            Console.WriteLine("error is " + error);
        }

        // reduce network error by additional teaching
        public void reduceError()
        {
            teacher.LearningRate = learningRate;
            teacher.Momentum = momentum;
            error = 0;

            Random randomG = new Random();

            for (int i = 0; i < iteration; i++)
            {
                if (randomMomentum)
                {
                    double random = (randomG.NextDouble() * 0.3) + 0.5;
                    teacher.Momentum = random;
                }
                error = teacher.RunEpoch(input, output) / sampleCount;
                if (outputErrorComponent != null)
                {
                    outputErrorComponent.Text = "Neural network error is : " + error;
                }
            }

            Console.WriteLine("error is " + error);
        }

        // compute output for a given input 
        public String computeOutput(double[] inputArgument)
        {
            for (int i = 0; i < inputArgument.Length; i++)
            {
                inputArgument[i] = inputArgument[i] / normaliser;
            }
            Double[] answer = network.Compute(inputArgument);
            for (int j = 0; j < 4; j++)
            {

                if (answer[j] > 0.7)
                {
                    answer[j] = 1.0;
                }

                else if (answer[j] < 0.2)
                {
                    answer[j] = 0.0;
                }
            }

            Console.WriteLine("" + answer[0] + answer[1] + answer[2] + answer[3]);

            if (arraysAreEquivalent(answer, angryType))
            {
                return "Angry";
            }

            else if (arraysAreEquivalent(answer, happyType))
            {
                return "Happy";
            }

            else if (arraysAreEquivalent(answer, sadType))
            {
                return "Sad";
            }

            else if (arraysAreEquivalent(answer, neutralType))
            {
                return "Neutral";
            }

            else
            {
                return "Unrecognised";
            }


        }

        // utility method - compare arrays
        public static bool arraysAreEquivalent(double[] array1, double[] array2)
        {
            Boolean equivalent = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    equivalent = false;
                    break;
                }
            }

            return equivalent;
        }

        // test network with training data
        public int[] test()
        {
            int correctCounter = 0;
            int incorrectCounter = 0;

            for (int i = 0; i < sampleCount; i++)
            {
                Double[] answer = network.Compute(input[i]);
                double[] tempOutput = output[i];

                for (int j = 0; j < 4; j++)
                {

                    if (answer[j] > 0.7)
                    {
                        answer[j] = 1.0;
                    }

                    else if (answer[j] < 0.2)
                    {
                        answer[j] = 0.0;
                    }

                }

                if (answer[0] == tempOutput[0] && answer[1] == tempOutput[1] && answer[2] == tempOutput[2] && answer[3] == tempOutput[3])
                {
                    correctCounter++;
                }
                else
                {
                    incorrectCounter++;
                }

                Console.WriteLine("network output =  " + answer[0] + " " + answer[1] + " " + answer[2] + " " + answer[3] + " ");
                Console.WriteLine("Output shold be = " + tempOutput[0] + " " + tempOutput[1] + " " + tempOutput[2] + " " + tempOutput[3] + " ");

            }

            Console.WriteLine("correct = " + correctCounter + " incorrect = " + incorrectCounter);
            int[] correctArray = { correctCounter, incorrectCounter };
            return correctArray;
        }

        // return neywrok error
        public double getError()
        {
            return error;
        }

        // output training data
        private void outPutLearningData()
        {
            Console.WriteLine("Number of samples = " + sampleCount);
            Console.WriteLine("Input");

            for (int i = 0; i < sampleCount; i++)
            {
                double[] temp = learningData[i];
                Console.WriteLine("min Per second: " + temp[0] + " max per second: " + temp[1] + " min avrage: " + temp[2] + " max average: " + temp[3]);
                // min Per second ,  max per second,  min avrage,  max average
            }

            Console.WriteLine("Output");

            for (int i = 0; i < sampleCount; i++)
            {
                double[] temp = learningData[i];
                Console.WriteLine(temp[4] + "" + temp[5] + "" + temp[6] + "" + temp[7]);
            }
        }

        // randomise training data
        private void randomize(double[][] list)
        {
            Random randomG = new Random();
            for (int i = 0; i < sampleCount; i++)
            {
                int randomNumber = randomG.Next(sampleCount - 1);
                double[] temp = learningData[i];
                learningData[i] = learningData[randomNumber];
                learningData[randomNumber] = temp;

            }
        }

        // reset configuration settings
        public void defaultSettings()
        {
            learningRate = 0.1;
            momentum = 0;
            sigmoidAV = 2;
            iteration = 1000;
            randomiseInputData = false;
            randomMomentum = true;
        }

        public double getLearningRate()
        {
            return learningRate;
        }

        public double getMomentum()
        {
            return momentum;
        }

        public double getSigmoidAV()
        {
            return sigmoidAV;
        }
           
        public double getIteration()
        {
            return iteration;
        }
        public bool getRandomiseInputData()
        {
            return randomiseInputData;
        }

        public bool getRandomMomentum()
        {
            return randomMomentum;
        }

        public void setConfiguration(double learningRateArg, double momentumArg, double sigmoidAVArg, double iterationArg, Boolean randomiseInputDataArg, Boolean randomMomentumArg)
        {
            learningRate = learningRateArg;
            momentum =  momentumArg;
            sigmoidAV =  sigmoidAVArg;
            iteration =  iterationArg; 
            randomiseInputData =  randomiseInputDataArg;
            randomMomentum = randomMomentumArg;
        }

        public void setOutputErrorComponent(Label componentArg)
        {
            outputErrorComponent = componentArg;
        }

     


    }
}

