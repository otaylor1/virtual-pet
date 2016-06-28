using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static Sloth MySloth = new Sloth();

        static void Main(string[] args)

        {
            MySloth.GetPetName();

            Console.WriteLine(MySloth.Name + "'s Statistics are:");
            MySloth.DisplayStatistics();
            Console.WriteLine("Be sure not to let " + MySloth.Name + "'s statistics get above 20 or below 0");
            Console.ReadKey();
            Console.Clear();

            int consequenceResult = 0;
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.WriteLine("Activities");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Give " + MySloth.Name + " food");
                Console.WriteLine("2. Give " + MySloth.Name + " water");
                Console.WriteLine("3. Play with " + MySloth.Name);
                Console.WriteLine("4. Take " + MySloth.Name + " for a walk");

                string responseAsText = Console.ReadLine();
                int response;
                response = Convert.ToInt32(responseAsText);

                if (response == 1)
                {
                    Console.WriteLine("\nYou fed {0} \n", MySloth.Name);

                    //Statistics
                    MySloth.Food++;
                    MySloth.Water--;
                    MySloth.Energy++;
                    MySloth.DisplayStatistics();
                    Console.ReadKey();
                    Console.Clear();

                    consequenceResult = MySloth.Consequences();
                }

                else if (response == 2)
                {
                    Console.WriteLine("\nYou gave {0} water  \n", MySloth.Name);

                    MySloth.Water++;
                    MySloth.Energy++;
                    MySloth.Boredom--;
                    MySloth.DisplayStatistics();
                    Console.ReadKey();
                    Console.Clear();

                    consequenceResult = MySloth.Consequences();
                }

                else if (response == 3)
                {
                    Console.WriteLine("\nYou played with {0} \n", MySloth.Name);

                    MySloth.Food -= 2;
                    MySloth.Water -= 3;
                    MySloth.Energy--;
                    MySloth.Boredom += 2;
                    MySloth.DisplayStatistics();
                    Console.ReadKey();
                    Console.Clear();

                    consequenceResult = MySloth.Consequences();
                }

                else if (response == 4)
                {
                    Console.WriteLine("\nYou walked {0}\n", MySloth.Name);

                    MySloth.Food--;
                    MySloth.Water -= 2;
                    MySloth.Energy--;
                    MySloth.Boredom++;
                    MySloth.DisplayStatistics();
                    Console.ReadKey();
                    Console.Clear();

                    consequenceResult = MySloth.Consequences();
                }

                else
                {
                    Console.WriteLine("Please enter a number 1-4");
                }

                if (consequenceResult == -1)
                {
                    continueLoop = false;
                }
            }
        }
    }
}
