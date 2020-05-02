using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                //Prompt user to indicate which calculation they wish to find
                Console.WriteLine("Enter 1 for Average Muzzle Velocity or 2 for Muzzle Angle");
                string stat = Console.ReadLine();

                //If they select average muzzle velocity
                if (stat == "1")
                {
                    bool stillContinue = true;

                    while (stillContinue)
                    {
                        string input = "";
                        int velocity1 = 0;
                        int velocity2 = 0;
                        int velocity3 = 0;

                        //Prompt user to input 3 muzzle velocities
                        Console.WriteLine("Input Velocity 1");
                        input = Console.ReadLine();
                        velocity1 = int.Parse(input);

                        Console.WriteLine("Input Velocity 2");
                        input = Console.ReadLine();
                        velocity2 = int.Parse(input);

                        Console.WriteLine("Input Velocity 3");
                        input = Console.ReadLine();
                        velocity3 = int.Parse(input);

                        //Calculate average muzzle velocity
                        SimpleBallisticsCalculator calculation = new SimpleBallisticsCalculator();

                        decimal avg = calculation.CalculateAverageMuzzleVelocity(velocity1, velocity2, velocity3);

                        //Write average muzzle velocity to the console
                        Console.WriteLine("Average Muzzle Velocity: " + avg);

                        //Prompt user to indicate if they wish to calculate angle
                        Console.WriteLine("Enter c to calculate Muzzle Angle or q to quit");
                        string continueStat = Console.ReadLine();

                        string angleInput = "";
                        decimal velocity = Convert.ToDecimal(avg);
                        decimal distance = 0.00m;

                        //If yes, prompt user to input target distance
                        Console.WriteLine("Enter the distance to the target");
                        angleInput = Console.ReadLine();
                        distance = decimal.Parse(angleInput);

                        //Calculate angle required to hit target
                        SimpleBallisticsCalculator angleCalculation = new SimpleBallisticsCalculator();
                        decimal angle = angleCalculation.CalculateMuzzleAngle(velocity, distance);

                        //Write angle to the console
                        Console.WriteLine("Muzzle Angle: " + angle + " Degrees Above Horizontal");
                        stillContinue = false;

                        //If no, return to top of program
                        if (continueStat == "q")
                        {
                            stillContinue = true;
                        }
                    }

                    

                }

                //Else if they select targeting
                else if (stat == "2")
                {
                    string input = "";
                    decimal velocity = 0.00m;
                    decimal distance = 0.00m;

                    //Prompt user to input muzzle velocity and target distance
                    Console.WriteLine("Enter the Velocity");
                    input = Console.ReadLine();
                    velocity = decimal.Parse(input);

                    Console.WriteLine("Enter the Distance to the Target");
                    input = Console.ReadLine();
                    distance = decimal.Parse(input);

                    //Caclulate angle required to hit target
                    SimpleBallisticsCalculator calculation = new SimpleBallisticsCalculator();
                    decimal angle = calculation.CalculateMuzzleAngle(velocity, distance);

                    //Write angle to the console
                    Console.WriteLine("Muzzle Angle: " + angle + " Degrees Above Horizontal");
                }

                //Prompt user to indicate if they wish to do more calculations
                //If yes, return to top of program
                Console.WriteLine("Enter c for new calculation or q to quit");
                string anotherStat = Console.ReadLine();

                if (anotherStat == "q")
                {
                    shouldContinue = false;
                }
                //Else end program
            }

            Console.WriteLine("Thank you for using my program!");
        }
    }
}