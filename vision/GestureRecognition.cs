using System.Drawing;
using System.Drawing.Imaging;
using System;

namespace vision
{
    /*
     * This class constructs the 2-D model of the body and is used for 
     * inferring features of body language based on the model 
     * 
     */
    class GestureRecognition
    {
        // declaration of variables
        private int lowestBodyYPosition ;
        private int highestBodyYPosition ;

        private int highestBodyXPosition;
        private int lowestBodyXPosition;

        private int lowestHandYPosition;
        private int highestHandYPosition;

        private int highestHandXPosition;
        private int lowestHandXPosition;

        private int veryClose;
        private int close;
        private int far;

        private string proximity ="";
        private string approachingDetracting = "";

        private int previousLowestBodyYPosition;

        private bool interactionReady;

        private string handGesture;

        private double motionLevel;

        // constructor
        public GestureRecognition()
        {
            veryClose = 50;
            close = 160;
            interactionReady = false;
        }

        // make model of body based on colour detection image
        public void makeModel(Bitmap orangeAndBlueColourImage)
        {
            int height = orangeAndBlueColourImage.Height;
            int width = orangeAndBlueColourImage.Width;

            BitmapData data = orangeAndBlueColourImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            

            int stride = data.Stride;

            unsafe
            {
                byte* pointer = (byte*)data.Scan0;

                lowestBodyYPosition = 241;
                highestBodyYPosition = -1;
                int yBodyCounter = 0;

                lowestHandYPosition = 241;
                highestHandYPosition = -1;
                int yHandCounter = 0;



                // find highest and lowest body y positions 
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int B = pointer[y * stride + (x * 3)];
                        int G = pointer[y * stride + (x * 3 + 1)];
                        int R = pointer[y * stride + (x * 3 + 2)];

                        if (R == 255 && G == 0 && B == 0)
                        {
                            yBodyCounter++;
                        }

                        else if (R == 255 && G == 255 && B == 0)
                        {
                            yHandCounter++;
                        }

                    }

                    if (yBodyCounter >= 5)
                    {
                        if (y < lowestBodyYPosition)
                        {
                            lowestBodyYPosition = y;
                        }

                        if (y > highestBodyYPosition)
                        {
                            highestBodyYPosition = y;
                        }

                    }
                    yBodyCounter = 0;

                    if (yHandCounter >= 5)
                    {
                        if (y < lowestHandYPosition)
                        {
                            lowestHandYPosition = y;
                        }

                        if (y > highestHandYPosition)
                        {
                            highestHandYPosition = y;
                        }

                    }
                    yHandCounter = 0;
                }

                // find highest and lowest body x positions
                int xBodyCounter = 0; ;
                highestBodyXPosition = -1;
                lowestBodyXPosition = 321;


                int xHandCounter = 0; ;
                highestHandXPosition = -1;
                lowestHandXPosition = 321;


                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int B = pointer[y * stride + (x * 3)];
                        int G = pointer[y * stride + (x * 3 + 1)];
                        int R = pointer[y * stride + (x * 3 + 2)];

                        if (R == 255 && G == 0 && B == 0)
                        {
                            xBodyCounter++;
                        }

                        else if (R == 255 && G == 255 && B ==0)
                        {
                            xHandCounter++;
                        }

                    }

                    if (xBodyCounter >= 5)
                    {
                        if (x > highestBodyXPosition)
                        {
                            highestBodyXPosition = x;
                        }

                        if (x < lowestBodyXPosition)
                        {
                            lowestBodyXPosition = x;
                        }

                    }
                    xBodyCounter = 0;


                    if (xHandCounter >= 5)
                    {
                        if (x > highestHandXPosition)
                        {
                            highestHandXPosition = x;
                        }

                        if (x < lowestHandXPosition)
                        {
                            lowestHandXPosition = x;
                        }

                    }
                    xHandCounter = 0;
                }
            }
            
            // infer features of body langauge from model
            if(interactionReady)
            {
                calculateApproachingOrDetracting();
                calculateProximity();
                calculateHandGesture();
                
            }
           

            orangeAndBlueColourImage.UnlockBits(data);
        }

        // Draw the model as an image for display
        public Bitmap drawModel(int imageHeight, int imageWidth)
        {
            int height = imageHeight;
            int width =  imageWidth;
            
            Bitmap resultImage = new Bitmap(width, height);

            BitmapData resultData = resultImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            
           int stride = resultData.Stride;

           unsafe
           {
               byte* pointer = (byte*)resultData.Scan0;

               // draw model of body
               for (int y = lowestBodyYPosition; y <= highestBodyYPosition; y++)
               {
                   for (int x = lowestBodyXPosition; x <= highestBodyXPosition; x++)
                   {
                       if ((y == lowestBodyYPosition || y== highestBodyYPosition || x == highestBodyXPosition || x == lowestBodyXPosition))
                       {
                           pointer[y * stride + (x * 3)] = 0;
                           pointer[y * stride + (x * 3+1)] = 0;
                           pointer[y * stride + (x * 3+2)] = 255;

                       }

                   }
               }

               // draw model of hand
               for (int y = lowestHandYPosition; y <= highestHandYPosition; y++)
               {
                   for (int x = lowestHandXPosition; x <= highestHandXPosition; x++)
                   {

                       if ((y == lowestHandYPosition || y == highestHandYPosition || x == highestHandXPosition || x == lowestHandXPosition))
                       {
                           pointer[y * stride + (x * 3)] = 0;
                           pointer[y * stride + (x * 3 + 1)] = 255;
                           pointer[y * stride + (x * 3 + 2)] = 255;
                       }
                   }
               }

               // draw proximity lines
               for (int y = 0; y < height; y++)
               {                   
                   for (int x = 0; x < width; x += 4)
                   {
                       if(y==close|| y== veryClose)
                       {
                           pointer[y * stride + (x * 3)] = 255;
                           pointer[y * stride + (x * 3 + 1)] = 255;
                           pointer[y * stride + (x * 3 + 2)] = 255;
                       }
                    
                   }
                   
               }
           
           
           }
           resultImage.UnlockBits(resultData);
           return resultImage;


        }

        // infer proximity
        public void calculateProximity()
        {
            if(lowestBodyYPosition <= veryClose)
            {
                proximity = "Close";
            }

            else if (lowestBodyYPosition > veryClose && lowestBodyYPosition <= close)
            {
                proximity = "Medium";
            }

            else
            {
                proximity = "Far";
            }
        }

        // infer whether approaching or detraacting
        public void calculateApproachingOrDetracting()
        {
            int currentLowestBodyYPosition = lowestBodyYPosition;
            int difference = currentLowestBodyYPosition - previousLowestBodyYPosition;
            if(difference>30)
            {
                approachingDetracting = "Detracting";
                previousLowestBodyYPosition = currentLowestBodyYPosition;
            }
            else if (difference < -30)
            {
                approachingDetracting = "Approaching";
                previousLowestBodyYPosition = currentLowestBodyYPosition;
            }
        }

        public string getProximity()
        {
            return proximity;
        }

        public string getApproachingOrDetracting()
        {
            return approachingDetracting;
        }

        public void setInteractionReady(bool value)
        {
            interactionReady = value;
        }

        public void setPreviousLowestBodyYPosition()
        {
            previousLowestBodyYPosition = lowestBodyYPosition;
        }

        // infer hand gesture
        public void calculateHandGesture()
        {
            int handDistance = Math.Abs(highestHandXPosition - lowestHandXPosition);
            int bodyWidth = Math.Abs(highestBodyXPosition-lowestBodyXPosition);
            
            if(handDistance > bodyWidth * 2 )
            {
              
                handGesture = "Open";
            }

            else if(handDistance < bodyWidth)
            {
                handGesture = "Closed";
            }

            else
            {
                handGesture = "Neutral";
            }
        }

        // calculate body motion
        public void calculateBodyMotion(Bitmap thresholdImage)
        {
            Bitmap copyImage = new Bitmap(thresholdImage, thresholdImage.Width, thresholdImage.Height);
            double whitePixelCount =0; // white rgb = 255,255,255

            int height = copyImage.Height;
            int width = copyImage.Width;

            BitmapData data = copyImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = data.Stride;

            unsafe
            {
                byte* pointer = (byte*)data.Scan0;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        int value = pointer[y * stride + (x * 3)];
                        if (value == 255)
                        {
                            whitePixelCount++;
                        }
                        
                    }
                }
            }

            copyImage.UnlockBits(data);
            try
            {
                int normaliser = 5;
                motionLevel =  (whitePixelCount / ((height * width)/normaliser)) * 100;
                
                
            }
            catch (DivideByZeroException)
            {
                motionLevel = 0;
            }
            
        }

        public String getHandGesture()
        {
            return handGesture;
        }

        public int getMotionLevel()
        {
            return (int) motionLevel;
        }

        

    }
}
