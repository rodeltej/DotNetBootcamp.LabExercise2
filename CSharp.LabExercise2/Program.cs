using System;

namespace CSharp.LabExercise2
{


    class Lasagna
    {
       

        public void ExpectedMinutesInOven()
        {
            Console.WriteLine("Expected time in the oven: 40 minutes");
        }

        public void RemainingMinutesInOven(int num1)
        {
            int remainingMinutesInOven = 40 - num1;
            Console.WriteLine($"Remaining minutes in the oven: {remainingMinutesInOven} minutes");
        }

        public void PreparationTimeInMinutes(int num2)
        {
            int preparationTimeInMinutes = num2 * 2;
            Console.WriteLine($"Spent time in preparing the lasagna: {preparationTimeInMinutes} minutes");
        }

        public void ElapsedTimeInMinutes(int num3, int num4)
        {
            int elapsedTimeInMinutes = (num3 * 2) + num4;
            Console.WriteLine($"Total time spent on cooking the lasagna: {elapsedTimeInMinutes} minutes");
        }

    }




    class Program
    {

        static void Number1()
        {

            int[] fiveNumbers = new int[5];

            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                Console.Write("Enter number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                var check = Array.Exists(fiveNumbers, x => x == inputNumber);

                if (inputNumber < 10 || inputNumber > 100)
                {
                    Console.WriteLine("Number must be between 10 and 100.");
                    i--;
                }
                else if(check == false && inputNumber >=10 && inputNumber <= 100)
                {
                    fiveNumbers[i] = inputNumber;
                    for (int j=0; j < i+1; j++)
                    {
                        Console.Write($"{fiveNumbers[j]} ");                       
                    }
                    Console.WriteLine("");
                }
                else if (check == true)
                {
                    for (int j = 0; j < i+1; j++)
                    {
                        if(fiveNumbers[j] > 0)
                        {
                            Console.Write($"{fiveNumbers[j]} ");
                        }
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine($"{inputNumber} has already been entered.");
                    i--;
                }


            }


        }


        static void Number2()
        {


            Console.WriteLine("Welcome to Lasagna Cooking Time Assistant");
            Console.WriteLine("");
            Console.WriteLine("[1] Expected Oven Time in Minutes");
            Console.WriteLine("[2] Remaining Oven Time in Minutes");
            Console.WriteLine("[3] Preparation Time in Minutes");
            Console.WriteLine("[4] Elapsed Time in Minutes");
            Console.Write("\nEnter choice number: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            var lasagna = new Lasagna();
            Console.WriteLine("");

            if (choice == 1)
            {
                lasagna.ExpectedMinutesInOven();
            }
            else if (choice == 2)
            {
                Console.Write("\nHow long (in minutes) has the lasagna been inside the oven: ");
                int time1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                if (time1 < 40)
                {
                    lasagna.RemainingMinutesInOven(time1);
                }
                else if (time1 == 40)
                {
                    Console.WriteLine("Take out the lasagna from the oven, it is now fully cooked.");
                }
                else if (time1 > 40)
                {
                    Console.WriteLine("The lasagna is overcooked!. Quickly take it out from the oven now!");
                }
                
            }
            else if (choice == 3)
            {
                Console.Write("\nHow many layers did you add to the lasagna: ");
                int layer1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                lasagna.PreparationTimeInMinutes(layer1);
            }
            else if (choice == 4)
            {
                Console.Write("How many layers did you add to the lasagna: ");
                int layer1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nHow long (in minutes) has the lasagna been inside the oven: ");
                int time1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if(time1 < 40)
                {
                    lasagna.ElapsedTimeInMinutes(layer1, time1);
                }
                else if (time1 == 40)
                {
                    lasagna.ElapsedTimeInMinutes(layer1, time1);
                    Console.WriteLine("Take out the lasagna from the oven, it is now fully cooked.");
                }
                else if (time1 > 40)
                {
                    lasagna.ElapsedTimeInMinutes(layer1, time1);
                    Console.WriteLine("The lasagna is overcooked!. Quickly take it out from the oven now!");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
               

        }



        static void Main(string[] args)
        {
            Number1();
            //Number2();
            
        }
    }
}
