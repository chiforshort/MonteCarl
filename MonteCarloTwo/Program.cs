using System;

namespace MonteCarloTwo
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        struct Coordinates
        {
            Coordinates(double x, double y)
            {
                double X = x;
                double Y = y;
            }

            public static double RandomNub(double x, double y);
            {

            }
        }

    }
}

/* 1.Why do we multiply the value from step 5 above by 4?
   

   2.What do you observe in the output when running your program with parameters of increasing size?

   3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?

   4. Find a parameter that requires multiple seconds of run time.What is that parameter? How accurate is the estimated value of π?

   5. Research one other use of Monte-Carlo methods.Record it in your exercise submission and be prepared to discuss it in class.
