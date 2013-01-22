using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;  

namespace vision
{
    /*
     * This class performs the image processing operations such as convolution, thresholding, colour detection etc. 
     * 
     */
    class ImageProcessing
    {
        // declaration of variables
        private int[] handR;
        private int[] handG;
        private int[] handB;

        private int[] bodyR;
        private int[] bodyG;
        private int[] bodyB;

        // constructor
        public ImageProcessing()
        {
            readHandCloursFromTextFile();
            readBodyCloursFromTextFile();
        }

        // grey scale operation
        public Bitmap grayscale( Bitmap originalImage)
        {
            Bitmap resultImage = new Bitmap(originalImage, originalImage.Width, originalImage.Height);

            int height = resultImage.Height;
            int width = resultImage.Width;

            BitmapData data = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);                  
            int stride = data.Stride;
            unsafe
            {
                 byte* pointer = (byte*)data.Scan0;

                 for (int y = 0; y < height; y++)
                 {
                       for (int x = 0; x < width; x++)
                            {
                                int average = (pointer[y * stride + (x * 3)] + pointer[y * stride + (x * 3 + 1)] + pointer[y * stride + (x * 3 + 2)]) / 3;
                                pointer[y * stride + (x * 3)] = pointer[y * stride + (x * 3 + 1)] = pointer[y * stride + (x * 3 + 2)] = (byte)average;
                            }
                 }
            }

            resultImage.UnlockBits(data);
            return resultImage;
        }
        
        // make an image representing difference between two images
        public Bitmap subtraction(Bitmap image1, Bitmap image2)
        {
            int height = image1.Height;
            int width =  image1.Width;
            
            Bitmap resultImage = new Bitmap(width, height);

            BitmapData data1 = image1.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData data2 = image2.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = data1.Stride;

            unsafe
            {
                byte* pointer1 = (byte*)data1.Scan0;
                byte* pointer2 = (byte*)data2.Scan0;
                byte* pointer3 = (byte*)resultData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int difference = Math.Abs(pointer1[y * stride + (x * 3)] - pointer2[y * stride + (x * 3)]);
                        pointer3[y * stride + (x * 3)] = pointer3[y * stride + (x * 3+1)] = pointer3[y * stride + (x * 3+2)]  = (byte) difference;
                        
                    }
                }
            }

            image1.UnlockBits(data1);
            image2.UnlockBits(data2);
            resultImage.UnlockBits(resultData);
         

            return resultImage;
        }

        // simple threshold operation 
        public Bitmap simpleThreshold(Bitmap originalImage)
        {
            int height = originalImage.Height;
            int width =  originalImage.Width;

            Bitmap resultImage = new Bitmap(width, height);

            BitmapData data = originalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = data.Stride;

            unsafe
            {
                byte* pointer = (byte*)data.Scan0;
                byte* pointer2 = (byte*)resultData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int value = pointer[y * stride + (x * 3)];

                        if (value > 25)
                        {
                            pointer2[y * stride + (x * 3)] = pointer2[y * stride + (x * 3 + 1)] = pointer2[y * stride + (x * 3 + 2)] = 255;
                        }
                        else
                        {
                            pointer2[y * stride + (x * 3)] = pointer2[y * stride + (x * 3 + 1)] = pointer2[y * stride + (x * 3 + 2)] = 0;
                        
                        }
                       

                    }
                }
            }

            originalImage.UnlockBits(data);
            resultImage.UnlockBits(resultData);
            
            return resultImage;

        }

       // iterative threshold operation
        public Bitmap iterativeThreshold(Bitmap originalImage)
        {
            int height = originalImage.Height;
            int width = originalImage.Width;

            Bitmap resultImage = new Bitmap(width, height);

            BitmapData data = originalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int thresholdInitialValue = 0;
            int thresholdCurrentValue = 0;
            int thresholdNewValue = 0;
            int thresholdFinalValue = 0;
            
            int sumBackgroundValue = 0;
            int sumObjectValue = 0;

            int avgObjectValue = 0;
            int avgBackgroundValue = 0;

            int threshold_startingValue = 170;



            // Initial threshold 
            unsafe
            {
                int stride = data.Stride;

                byte* pointer1 = (byte*)data.Scan0;
                byte* pointer2 = (byte*)resultData.Scan0;                
                
                thresholdInitialValue = threshold_startingValue; 

                thresholdNewValue = thresholdInitialValue;
             
                while (Math.Abs(thresholdCurrentValue - thresholdNewValue) > 1) 
                {
                    thresholdCurrentValue = thresholdNewValue;

                    sumBackgroundValue = 0;
                    int counterBackground = 0;

                    sumObjectValue = 0;
                    int counterObject = 0;

                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                        {
                            int value = pointer1[y * stride + (x * 3)];
                            if (value < thresholdCurrentValue)
                            {
                                sumBackgroundValue += value;
                                counterBackground += 1;
                            }

                            else if (value > thresholdCurrentValue)
                            {
                                sumObjectValue += value;
                                counterObject += 1;
                            }
                        }

                    try
                    {
                        avgObjectValue = sumObjectValue / counterObject;
                        avgBackgroundValue = sumBackgroundValue / counterBackground;
                        thresholdNewValue = (avgObjectValue + avgBackgroundValue) / 2;
                    }
                    catch (DivideByZeroException)
                    {
                        thresholdNewValue = threshold_startingValue;
                    }

                }


                thresholdFinalValue = thresholdNewValue;

                // thresholding with thresholdFinal

                for (int y = 0; y < height; y++)
                    for (int x = 0; x < width; x++)
                    {
                        for (int z = 0; z < 3; z++) // control rgb values 
                        {
                            int value = pointer1[y * stride + (x * 3 + z)];
                            if (value < thresholdFinalValue) 
                            { 
                                pointer2[y * stride + (x * 3 + z)] = 0; 
                            }
                            else 
                            { 
                                pointer2[y * stride + (x * 3 + z)] = 255; 
                            }
                        }
                    }
             	
            }

            originalImage.UnlockBits(data);
            resultImage.UnlockBits(resultData);

            return resultImage;
        }

        // do averaging with weighted averaging filter
        public Bitmap averaging(Bitmap originalImage)
        {
            int maskHeight = 3;
            int maskWidth = 3;
            int maskSum = 9; 
            int [] convolutionMask = {1,2,1,2,4,2,1,2,1};	// weighted averaging filter
	       
        	
	         Bitmap resultImage = convolution(originalImage, convolutionMask, maskHeight,maskWidth,maskSum, false );
             return resultImage;

        }

        // apply generic convolutionn operation
        public Bitmap convolution(Bitmap originalImage, int [] convolutionMask, int maskHeight,int maskWidth, int maskSum, bool doAbsoluteValues )
        {
	        int height = originalImage.Height;
            int width =  originalImage.Width;
            
            Bitmap resultImage = new Bitmap(width, height);

            BitmapData data = originalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            
           int stride = data.Stride;

           unsafe
           {
                byte* pointer = (byte*)data.Scan0;
                byte* pointer2 = (byte*)resultData.Scan0;
               
                 int RSum = 0;
                 int GSum = 0;
                 int BSum = 0;

                 for( int y=0;y<height-maskHeight;y++)
  		                for(int x=0;x<width-maskWidth;x++)
	                {                    		
		                for (int vertical = 0; vertical < maskHeight; vertical ++)
		                {
			                for(int horizontal = 0; horizontal < maskWidth ; horizontal ++)
			                {

                                RSum   +=  convolutionMask [vertical * maskHeight + horizontal ]   *   pointer[  (y+vertical)    *stride   +  ((x +horizontal) *3)];
   				                GSum   +=  convolutionMask [vertical * maskHeight + horizontal ]   *   pointer[  (y+vertical)    *stride   +  ((x +horizontal) *3 + 1)];
			                    BSum   +=  convolutionMask [vertical * maskHeight + horizontal ]   *   pointer[  (y+vertical)    *stride   +  ((x +horizontal) *3 + 2)];
				
			                }
            		 
		                }

	                int Rnew = RSum/maskSum;
	                int Gnew = GSum/maskSum;
	                int Bnew = BSum/maskSum;

            		
	                if (doAbsoluteValues == true)
	                {
		                if (Rnew < 0){Rnew = Rnew * -1;}	
		                if (Gnew < 0){Gnew = Gnew * -1;}	
		                if (Bnew < 0){Bnew = Bnew * -1;}	
	                }

                    if (Rnew < 0){Rnew = 0;}
	                if (Rnew > 255){Rnew = 255;}

	                if (Gnew < 0){Gnew = 0;}
	                if (Gnew > 255){Gnew = 255;}

	                if (Bnew < 0){Bnew = 0;}
	                if (Bnew > 255){Bnew = 255;}
            		
	                int verticalCenter = maskHeight/2;
	                int horizontalCenter = maskWidth/2;

	                pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)   *3)]    = (byte) Rnew ;
	                pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)   *3 +1)] = (byte) Gnew;
	                pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)   *3 +2)] = (byte) Bnew;

	                 RSum = 0;	
	                 GSum = 0;
    	             BSum = 0;
                            
            	
  	             }

           }

            originalImage.UnlockBits(data);
            resultImage.UnlockBits(resultData);
            
            return resultImage;
         }

        // apply order statistic median operation 
        public Bitmap  orderStatisticMedian(Bitmap originalImage)
        {
            int maskWidth = 3;
            int maskHeight = 3;

	        return orderStatistic(originalImage,  maskHeight, maskWidth,0 );	
        }

        // apply generic order statistic operation 
        public Bitmap orderStatistic(Bitmap originalImage, int maskHeight, int maskWidth, int function)
         {
        	
	         int height = originalImage.Height;
             int width =  originalImage.Width;
                    
             Bitmap resultImage = new Bitmap(width, height);

             BitmapData data = originalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
             BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                    
             int stride = data.Stride;

            unsafe
            {

               byte* pointer = (byte*)data.Scan0;
               byte* pointer2 = (byte*)resultData.Scan0;

	           int [] RArray   = new int  [maskHeight * maskWidth  ] ;
               int [] GArray   = new int  [maskHeight * maskWidth  ] ;
	           int [] BArray  =  new int  [maskHeight * maskWidth  ] ;
            	 
            	

	             for( int y=0;y<height-maskHeight;y++)
      		        for(int x=0;x<width-maskWidth;x++)
		            { 		
			            for (int vertical = 0; vertical < maskHeight; vertical ++)
			            {
				            for(int horizontal = 0; horizontal < maskWidth ; horizontal ++)
				            {
				                 RArray [vertical * maskHeight + horizontal]  =    pointer[ (y+vertical)     *stride   +   ((x +horizontal)      *3)];
       				             GArray [vertical * maskHeight + horizontal]  =    pointer[ (y+vertical)     *stride   +   ((x +horizontal)      *3 + 1)];
				                 BArray [vertical * maskHeight + horizontal]  =    pointer[ (y+vertical)     *stride   +   ((x +horizontal)      *3 + 2)];
        								
				            }
            				 
			            }

			               int Rnew   =0;
			               int Gnew   =0;
			               int Bnew   =0;			

			                     			
			             if (function == 0) 
			            {
                            Rnew = medianFunction(RArray, maskHeight * maskWidth);
                            Gnew = medianFunction(GArray, maskHeight * maskWidth);
                            Bnew = medianFunction(BArray, maskHeight * maskWidth);
			            }
            		  		
			            int verticalCenter = maskHeight/2;
			            int horizontalCenter = maskWidth/2;

			            pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)     *3)]    =    (byte) Rnew ;
			            pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)     *3 +1)] = (byte) Gnew;
			            pointer2[  (y + verticalCenter)    *stride   +  ((x+ horizontalCenter)     *3 +2)] =(byte) Bnew;
	
      	           }
               
            }

            originalImage.UnlockBits(data);
            resultImage.UnlockBits(resultData);

            return resultImage;
        }

         // utility method - calculate median of data
        private int medianFunction(int [] mask, int maskSize)
        {
	        bubbleSort(mask, maskSize);
	        return mask [ (maskSize/2)  ];
        	
        }
        // utility method bubble sort
            private void bubbleSort(int [] array , int size)
        {
            for (int iteration=1; iteration < size; iteration++) 
	        {                     
       	           for (int i=0; i < size-iteration; i++) 
	           {
                       if (array[i] > array[i+1]) 
	               {
                       int temp = array[i];  
		               array[i] = array[i+1];  
		               array[i+1] = temp;
                       }
                    }
                 }
        }

        // find body and hand based on colour detection
        public Bitmap findBodyAndHand(Bitmap originalImage)
        {
            int height = originalImage.Height;
            int width =  originalImage.Width;

            Bitmap resultImage = new Bitmap(width, height);

            BitmapData data = originalImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = data.Stride;

            unsafe
            {
                byte* pointer = (byte*)data.Scan0;
                byte* pointer2 = (byte*)resultData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //pixel order is reversed in bitmaps. Not rgb, but bgr
                        int B = pointer[y * stride + (x * 3)];
                        int G = pointer[y * stride + (x * 3+1)];
                        int R = pointer[y * stride + (x * 3 + 2)];

                        if (isOrange(R, G, B))
                        {
                            pointer2[y * stride + (x * 3)] = 0;
                            pointer2[y * stride + (x * 3 + 1)] = 0;
                            pointer2[y * stride + (x * 3 + 2)] = 255;

                        }
                        
                        if (isOrange2(R, G, B))
                        {
                             pointer2[y * stride + (x * 3)] = 0;
                             pointer2[y * stride + (x * 3 + 1)] = 0;
                             pointer2[y * stride + (x * 3 + 2)] = 255;

                         }

                        else if (isYellow(R,G,B))
                        {
                            pointer2[y * stride + (x * 3)] = 0;
                            pointer2[y * stride + (x * 3 + 1)] = 255;
                            pointer2[y * stride + (x * 3 + 2)] = 255;
                        }
                        

                    }
                }
               
            }

            originalImage.UnlockBits(data);
            resultImage.UnlockBits(resultData);
            return resultImage;
           
        }

        // orange bib colour detection 
        public bool isOrange(int R, int G, int B)
        {
            bool isOrange = false;
            for (int index = 0; index< bodyR.Length; index++)
            {
                int r = bodyR[index];
                int g = bodyG[index];
                int b = bodyB[index];

                int diffR = Math.Abs(r-R);
                int diffG = Math.Abs(g-G);
                int diffB = Math.Abs(b-B);

                if(diffR <8 && diffG <8 && diffB <8 )
                {
                    isOrange = true;
                    break;
                }                 
            }

            return isOrange;
        }

       // orange bib colour detection - second technique
        private bool isOrange2(int R, int G, int B)
        {
            //set                   0        1      2       3       4       5       
            int[] rUpperLimit = { 254,      245,   222,    198,    167,    198 - 10 };
            int[] rLowerLimit = { 242,      239,   207,    177,    148,    175 + 10 };

            int[] gUpperLimit = { 144,      118,   99,     85,     44,     109 - 10 };
            int[] gLowerLimit = { 129,      106,   88,     69,     30,     81 + 10 };

            int[] bUpperLimit = { 173,      134,   106,    104,    49,     117 - 10 };
            int[] bLowerLimit = { 143,      113,   96,     85,     43,     83 + 10 };

            bool match = false;

            // threshold colour detection
            for (int index = 0; index < rUpperLimit.Length; index++)
            {

                match = thresholdColourDetection(R, G, B, rUpperLimit[index] + 10, rLowerLimit[index] - 10, gUpperLimit[index] + 10, gLowerLimit[index] - 10, bUpperLimit[index] + 10, bLowerLimit[index] - 10);

                if (match)
                {
                    break;

                }
            }
            return match;

            /* 
                        
            // euclidian vector distance colour detection
            int refR = 188;
            int refG = 99;
            int refB = 102;
                        
            int toleranceThreshold = 30;

           match = euclidianVectorDistanceColourDetection(refR, refG, refB, R, G, B, toleranceThreshold);

            if(match)
            {
                pointer2[y * stride + (x * 3)] = 0;
                pointer2[y * stride + (x * 3 + 1)] = 0;
                pointer2[y * stride + (x * 3 + 2)] = 255;
            }
                        
             */
        }

   
        // threshold colour matching algorithm
        private bool thresholdColourDetection(int rValue, int gValue, int bValue, int rUpperLimit, 
                                                     int rLowerLimit, int gUpperLimit, int gLowerLimit, int bUpperLimit, int bLowerLimit)
        {
            return    ((rValue  <= rUpperLimit && rValue >= rLowerLimit) 
                   &&  (gValue   <= gUpperLimit && gValue >= gLowerLimit) 
                   &&  (bValue   <= bUpperLimit && bValue >= bLowerLimit));   
        }

        // euclidian distance colour matching algorithm
        private bool euclidianVectorDistanceColourDetection(int rRef, int gRef, int bRef, int rValue, int gValue, int bValue, int toleranceThreshold)
        {
            int euclidianDistance = (int)Math.Sqrt(Math.Pow(rValue - rRef, 2) + Math.Pow(gValue - gRef, 2) + Math.Pow(bValue - bRef, 2));
            return euclidianDistance < toleranceThreshold;
        }

        // read hand colours from reference image file
        public void readHandColoursFromImage()
        {
            FileStream fs = File.OpenRead("yellowHand1.png");
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);

            MemoryStream ms = new MemoryStream(data);
            Bitmap bmp = new Bitmap(ms);

            int height = bmp.Height;
            int width = bmp.Width;
            handR = new int [height * width];
            handG = new int [height * width];
            handB = new int [height * width];


            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmpData.Stride;
            unsafe
            {
                byte* pointer = (byte*)bmpData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                      handB[y*width + x] =  pointer[y * stride + (x * 3)] ;
                      handG[y*width + x] =  pointer[y * stride + (x * 3+1)] ;
                      handR[y*width + x] =  pointer[y * stride + (x * 3+2)]; 
                        
                    }
                }
            }

            bmp.UnlockBits(bmpData);

        }

        // read hand colours from text file
        public void readHandCloursFromTextFile()
        {
                
                List <int> rList = new List<int>();
                List<int>  gList = new List<int>();
                List<int>  bList = new List<int>();

                StreamReader input = new StreamReader("yellowHandColoursV2.txt");           
                String textLine;
                while ((textLine = input.ReadLine()) != null)
                {
                    
                    String RGBComponent;
                    int RGBValue;
                    if(textLine.Contains("="))
                    {
                        int indexOfEqualsChar = textLine.IndexOf("=");
                        RGBComponent = textLine.Substring(0, indexOfEqualsChar);
                        
                        RGBValue = int.Parse(textLine.Substring(indexOfEqualsChar + 1).Trim());

                       
                        if (RGBComponent == "R")
                        {
                            rList.Add(RGBValue);
                        }
                        else if (RGBComponent == "G")
                        {
                            gList.Add(RGBValue);
                        }

                        else if (RGBComponent == "B")
                        {
                            bList.Add(RGBValue);
                        }
                    }
                   

                }

                handR = rList.ToArray();
                handG = gList.ToArray();
                handB = bList.ToArray();

               

            
        }

        // yellow paper colour detection
        public bool isYellow(int R, int G, int B)
        {
            bool isYellow = false;
            for (int index = 0; index< handR.Length; index++)
            {
                int r = handR[index];
                int g = handG[index];
                int b = handB[index];

                int diffR = Math.Abs(r-R);
                int diffG = Math.Abs(g-G);
                int diffB = Math.Abs(b-B);

                if(diffR <8 && diffG <8 && diffB <8 )
                {
                    isYellow = true;
                    break;
                }                 
            }

            return isYellow;
        }

        // read body colours from text file
        public void readBodyCloursFromTextFile()
        {

            List<int> rList = new List<int>();
            List<int> gList = new List<int>();
            List<int> bList = new List<int>();

            StreamReader input = new StreamReader("orangeBodyColours.txt");
            String textLine;
            while ((textLine = input.ReadLine()) != null)
            {

                String RGBComponent;
                int RGBValue;
                if (textLine.Contains("="))
                {
                    int indexOfEqualsChar = textLine.IndexOf("=");
                    RGBComponent = textLine.Substring(0, indexOfEqualsChar);

                    RGBValue = int.Parse(textLine.Substring(indexOfEqualsChar + 1).Trim());


                    if (RGBComponent == "R")
                    {
                        rList.Add(RGBValue);
                    }
                    else if (RGBComponent == "G")
                    {
                        gList.Add(RGBValue);
                    }

                    else if (RGBComponent == "B")
                    {
                        bList.Add(RGBValue);
                    }
                }


            } 

            bodyR = rList.ToArray();
            bodyG = gList.ToArray();
            bodyB = bList.ToArray();




        }


     
    }
}
