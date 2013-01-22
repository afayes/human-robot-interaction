using System;
using Netica;

namespace robot
{
    /*
     * This class represents a Bayesian network implementation of the robot personality. 
     * This class uses the Netica Bayesian network API to interface to the file ‘robotPersonalityBN.bn’.   
     * 
     */
    class BayesianNetwork_Personality
    {
        // declaration of variables
        private Application neticaApplication;
        private BNet bayesianNetwork;
        private double[] beliefs;
        private String[] robotPersonalityStates;

        // constructor
        public BayesianNetwork_Personality()
        {
            loadBayesianNetwork();
            beliefs = new double[8];
            String[] tempStates = { "Defensive", "Aggressive", "IntimidatingOrProtective", "Intimacy", "Friendly", "Interest", "DefensiveOrIntimacy", "Disinterest" };
            robotPersonalityStates = tempStates;
        }

        // load the personality netwrok from a file
        public void loadBayesianNetwork()
        {
            try
            {
                neticaApplication = new Netica.Application();
                string fileName = AppDomain.CurrentDomain.BaseDirectory + "robotPersonalityBN.dne";

                Streamer file = neticaApplication.NewStream(fileName, null);
                bayesianNetwork = neticaApplication.ReadBNet(file, "");
                bayesianNetwork.Compile();
                bayesianNetwork.RetractFindings();
                
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }

        // enter speech tone evidence into the bayesian network
        public void enterEvidenceVoiceTone(String tone)
        {
            bayesianNetwork.Node("VoiceTone").EnterFinding(tone);
        }

        // enter proximity evidence into the bayesian network
        public void enterEvidenceProximity(String proximity)
        {
            bayesianNetwork.Node("Proximity").EnterFinding(proximity);
        }
        
        // update the robot response probabilities
        public double[] updateBeliefs()
        {
            for (int i = 0; i < robotPersonalityStates.Length; i++ )
            {
                
                BNode node = bayesianNetwork.Node("RobotResponse");
                double belief_ = node.GetBelief(robotPersonalityStates[i]);
                double belief = double.Parse ( belief_.ToString("G4"));
                beliefs[i] = belief;
                
            }
            return beliefs;
        }

        // get the most likely robot response index
        public int getHighestBeliefStateIndex()
        {
            int highestIndex = -1;
            double highestBelief = -1;

            for (int i = 0; i < beliefs.Length; i++ )
            {
                if(beliefs[i] > highestBelief)
                {
                    highestBelief = beliefs[i];
                    highestIndex = i;
                }
            }

            return highestIndex;
        }
        
        // retract evidence from the bayesian network
        public void retractEvidence()
        {
            bayesianNetwork.RetractFindings();
           

        }



    }
}
