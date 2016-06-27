using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Sloth
    {
        public string Name { get; set; }
        public int Food { get; set; }
        public int Water { get; set; }
        public int Energy { get; set; }
        public int Boredom { get; set; }


        public Sloth()
        {
            Food = 10;
            Water = 10;
            Energy = 10;
            Boredom = 10;
        }

        public void GetPetName()
        {
            Console.WriteLine("You have just adopted a new Sloth!");
            Console.Write("What is its name? ");

            Name = Console.ReadLine();

            Console.WriteLine(Name + " is happy to meet you! \n");
        }

        public void DisplayStatistics()
        {
            Console.WriteLine("Statistics");
            Console.WriteLine("Food: {0}", Food);
            Console.WriteLine("Water: {0}", Water);
            Console.WriteLine("Energy: {0}", Energy);
            Console.WriteLine("Boredom: {0}", Boredom);
        }

        public int Consequences()
        {
            int returnValue = 0;
            if (Food > 20)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too full and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Water > 20)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too water logged and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Energy > 20)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too hyper and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Boredom > 20)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get to excited and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Food < 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too hungry and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Water < 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too dehydrated and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Energy < 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too tired and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }

            if (Boredom < 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry, you let " + Name + " get too lonley and die.");
                Console.WriteLine("Game Over");
                Console.ReadKey();
                returnValue = -1;
            }
            return returnValue;
        }
    }
}
