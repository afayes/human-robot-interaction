using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;

namespace robot
{
    /*
     * This class is used to interface with the USB UIRT device so IR codes can be sent to the robot
     * 
     */

    class USB_UIRT
    {
        // import the required functions from the DLL file
        [DllImport("uuirtdrv.dll", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int UUIRTTransmitIR(int hHandle, string sIRCode, int uCodeFormat, int uRepeatCount, int uInactivityWaitTime, int hEvent, int reserved0, int reserved1);
        
        [DllImport("uuirtdrv.dll", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int UUIRTOpen();

        [DllImport("uuirtdrv.dll", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int UUIRTClose(int hHandle);

        // declaration of variables
        private Hashtable codeTable;
        private int handle;
        private const short PRONTO = 0x10;
        private int IR_Format;

        // constructor
        public USB_UIRT()
        {
            codeTable = new Hashtable();
            makeCodeHashTable();

            handle = UUIRTOpen();
            IR_Format = PRONTO; 
        }
       
        // make robot do a particular action specified by the string parametetr
        public void transmitAction(string action)
        {
            String IRcode = (String) codeTable[action];    

            USB_UIRT.UUIRTTransmitIR(handle, IRcode, IR_Format, 1, 0, 0, 0, 0);
           
        }

        // send an IR code to the robot
        public void transmitCode(String codeArg)
        {
            String IRcode = codeArg;
            USB_UIRT.UUIRTTransmitIR(handle, IRcode, IR_Format, 1, 0, 0, 0, 0);
        }

        // make hash table of robot actions by reading actions and code from a file
        public void makeCodeHashTable()
        {
            try
            {
                StreamReader input = new StreamReader("IRCodes.txt");           
                String textLine;
                 while ((textLine = input.ReadLine()) != null)
                 {
                     String action;
                     String code;
                     int indexOfEqualsChar = textLine.IndexOf("=");
                     action = textLine.Substring(0, indexOfEqualsChar);
                     code = textLine.Substring(indexOfEqualsChar + 1);
                     codeTable.Add(action, code);
                 }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("error while trying to read file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}







