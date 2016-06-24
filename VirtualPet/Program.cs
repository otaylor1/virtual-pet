using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have just adopted a new Sloth!");
            Console.Write("What is its name? ");
            string name = Console.ReadLine();
            Console.WriteLine(name + " is happy to meet you!");
            Console.ReadKey();
            Console.Clear();

            int food = 5;
            int water = 5;
            int energy = 5;
            int boredom = 5;

            Console.WriteLine("Statistics");
            Console.WriteLine("Food: " + food);
            Console.WriteLine("Water: " + water);
            Console.WriteLine("Energy: " + energy);
            Console.WriteLine("Boredom: " + boredom);

            Console.WriteLine("");


            while (true)
            {
                Console.WriteLine("Activities");

                Console.WriteLine("Please select an option:");

                Console.WriteLine("1. Give " + name + " food");
                Console.WriteLine("2. Give " + name + " water");
                Console.WriteLine("3. Play with " + name);
                Console.WriteLine("4. Take " + name + " for a walk");
                Console.WriteLine("5. Have " + name + " go to sleep");

                string responseAsText = Console.ReadLine();
                int response;
                response = Convert.ToInt32(responseAsText);

                
                if (response == 1)
                {
                    Console.WriteLine("Statistics");
                    Console.WriteLine("You fed " + name);
                    Console.WriteLine("Food: " + food++);
                    Console.WriteLine("Water: " + water--);
                    Console.WriteLine("Energy: " + energy++);
                    Console.WriteLine("Boredom: " + boredom);
                    Console.ReadKey();


                    if (food > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too full and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too water logged and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hyper and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get to excited and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                    if (food < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hungry and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too dehydrated and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too tired and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too lonley and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                }


                else if (response == 2)
                {

                    Console.WriteLine("Statistics");
                    Console.WriteLine("You gave " + name + " water");
                    Console.WriteLine("Food: " + food);
                    Console.WriteLine("Water: " + water++);
                    Console.WriteLine("Energy: " + energy++);
                    Console.WriteLine("Boredom: " + boredom--);
                    Console.ReadKey();

                    if (food > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too full and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too water logged and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hyper and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get to excited and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                    if (food < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hungry and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too dehydrated and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too tired and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too lonley and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                }


                else if (response == 3)
                {

                    Console.WriteLine("Statistics");
                    Console.WriteLine("You played with" + name);
                    Console.WriteLine("Food: " + (food - 2));
                    Console.WriteLine("Water: " + (water - 3));
                    Console.WriteLine("Energy: " + energy--);
                    Console.WriteLine("Boredom: " + (boredom + 2));
                    Console.ReadKey();


                    if (food > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too full and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too water logged and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hyper and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get to excited and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                    if (food < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hungry and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too dehydrated and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too tired and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too lonley and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                }


                else if (response == 4)
                {

                    Console.WriteLine("Statistics");
                    Console.WriteLine("You walked " + name);
                    Console.WriteLine("Food: " + food--);
                    Console.WriteLine("Water: " + (water-2));
                    Console.WriteLine("Energy: " + energy--);
                    Console.WriteLine("Boredom: " + boredom++);
                    Console.ReadKey();

                    if (food > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too full and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too water logged and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hyper and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom > 20)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get to excited and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }



                    if (food < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too hungry and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (water < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too dehydrated and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (energy < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too tired and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }
                    if (boredom < 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sorry, you let " + name + " get too lonley and die.");
                        Console.WriteLine("Game Over");
                        Console.ReadKey();
                        return;
                    }


                }

                else if (response == 5)
                {

                    Console.WriteLine("Sweet dreams!");  

                    Console.ReadKey();
                    break;

                }

                else
                {

                    Console.WriteLine("Please enter a number 1-5");
                    
                }
            }
        }
    }
}
