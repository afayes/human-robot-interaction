using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace robot
{
    /*
     * This class represents the robot 
     * 
     */
    public class Robot
    {
      // declaration of variables
      private bool isListening;
      private bool isSeeing;
      private BayesianNetwork_Personality personality;
      private String[] robotResponseCategories;
      private String[][] categorisedResponses;
      private USB_UIRT uSBUIRT;
      private RobotIOGUI robotIOGUI;

      private String voiceToneInput;
      private String proximityInput;
      private String categoryOutput;
      private String responseOutput;

      //constructor
        public Robot()
      {
          personality = new BayesianNetwork_Personality();
          isListening = false;
          isSeeing = true;
          String[] tempCategories = { "Defensive", "Aggressive", "IntimidatingOrProtective", "Intimacy", "Friendly", "Interest", "DefensiveOrIntimacy", "Disinterest" };
          robotResponseCategories = tempCategories;
          categorisedResponses =  new String[robotResponseCategories.Length][];
          loadCategorisedResponses();
          uSBUIRT = new USB_UIRT();
          robotIOGUI = new RobotIOGUI();

      }

      // receive proximity input
        public void see (String proximityArg)
      {
           proximityInput = proximityArg;
           personality.enterEvidenceProximity(proximityInput);
           isSeeing = false;
           isListening = true;           
      }

      // receive speech input
        public void listen(String voiceToneArg)
      {
          voiceToneInput = voiceToneArg;
          personality.enterEvidenceVoiceTone(voiceToneInput);
          isListening = false;
          respond();
      }

      // make the robot respond
        public void respond()
      {
          personality.updateBeliefs();
          int responseIndex = personality.getHighestBeliefStateIndex();
          // respond code here
          String[] responses = categorisedResponses[responseIndex];
          categoryOutput = robotResponseCategories[responseIndex];

          Random randomG = new Random();
          // randomG.Next(int maxValue) returns a non negative number LESS than max value 
          int randomNumber = randomG.Next(responses.Length);
          String response = responses[randomNumber];
          uSBUIRT.transmitAction(response);

          responseOutput = response;

          robotIOGUI.updateGUI (voiceToneInput, proximityInput, categoryOutput, responseOutput);

          personality.retractEvidence();
          isSeeing = true;
      }
      // load robots categorised responses
        public void loadCategorisedResponses()
      {
          try
          {
              StreamReader input = new StreamReader("robotResponsesCategorised.txt");
              String textLine;
              while ((textLine = input.ReadLine()) != null)
              {
                  String category;
                  String responses;
                  int indexOfEqualsChar = textLine.IndexOf("=");
                  category = textLine.Substring(0, indexOfEqualsChar);
                  responses = textLine.Substring(indexOfEqualsChar + 1);

                  String[] responsesArray = responses.Split(' ');
                  int index = getCategoryIndex(category);
                  categorisedResponses[index] = responsesArray;
              }

              input.Close();

             

          }
          catch (Exception e)
          {
              Console.WriteLine("error while trying to read file:");
              Console.WriteLine(e.Message);
          }
      }

      public bool getIsSeeing()
      {
          return isSeeing;
      }

      public bool getIsListening()
      {
          return isListening;
      }

      public void setIsListening(bool listeningArg)
      {
          isListening = listeningArg;
      }

      // get index of response category
        private int getCategoryIndex(String categoryArg)
      {
          int index = -1;
          for (int i = 0; i < robotResponseCategories.Length; i++ )
          {
              if(robotResponseCategories[i] == categoryArg)
              {
                  index = i;
              }
          }
          return index;
      }

        // output categorised responses
        public void outputCategorisedResponses()
        {
            for (int i = 0; i < categorisedResponses.Length; i++ )
            {
                Console.WriteLine("\n" + robotResponseCategories[i] + ":" + "\n");
                String[] responses = categorisedResponses[i];
                foreach (String response in responses)
                {
                    Console.WriteLine(response);
                }
            }
        }

        public RobotIOGUI getRobotGUI()
        {
            return robotIOGUI;
        }


        
    }
}
