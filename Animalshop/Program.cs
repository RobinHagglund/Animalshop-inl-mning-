using System;
using System.Collections.Generic;

namespace Animalshop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Snake> snakes = new List<Snake>();
            snakes.Add(new Snake("Cobra", true, true, 100, 2, "Female"));
            snakes.Add(new Snake("Cobra", true, true, 100, 3, "Male"));
            snakes.Add(new Snake("Snok", false, false, 100, 1, "Male"));
            snakes.Add(new Snake("Snok", false, false, 100, 2, "Male"));

            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird("Carrot", true, true, 50, 1, "Male"));
            birds.Add(new Bird("Carrot", true, true, 50, 3, "Female"));
            birds.Add(new Bird("Undelat", false, false, 50, 2, "Female"));           
            birds.Add(new Bird("Undelat", false, false, 50, 2, "Male"));

            List<Fish> fishes = new List<Fish>();
            fishes.Add(new Fish("Goldfish", true, true, 50, 1, "Male"));
            fishes.Add(new Fish("Goldfish", true, true, 50, 3, "Male"));
            fishes.Add(new Fish("Guppy", false, false, 50, 2, "Female"));           
            fishes.Add(new Fish("Guppy", false, false, 50, 2, "Male"));

            bool continue1 = true;

            while (continue1)
            {
                MenuIndex();

                string menu = Console.ReadLine();

                //Menu
                switch (menu)
                {
                    case "1":
                        MenuBuyAnimal();

                    string buymenu = Console.ReadLine();
                    switch (buymenu)
                    {
                        case "1":
                                Console.WriteLine("These are the kind of snakes we have for sell:");
                                Console.WriteLine("");
                            foreach (var snake in snakes)
                            {
                                Console.WriteLine("Species: " + snake.snakeType + "| Age: " + snake.age + " | Sex: "+ snake.sex + " | Price: " + snake.price + " | ID: " + snake.Id);
                                    Console.WriteLine(" ");
                            }
                                Console.WriteLine("What snake do you want to buy? Enter ID of that animal.");
                                int snakeChart = Convert.ToInt32(Console.ReadLine());
                            break;

                        case "2":
                                Console.WriteLine("These are the kind of birds we have for sell:");
                                Console.WriteLine("");
                            foreach (var bird in birds)
                            {
                                Console.WriteLine("Species: " + bird.birdType + "| Age: " + bird.age + " | Sex: " + bird.sex + " | Price: " + bird.price + " | ID: " + bird.Id);
                                    Console.WriteLine(" ");
                                }
                            break;
                        case "3":
                                Console.WriteLine("These are the kind of fish we have for sell:");
                                Console.WriteLine("");
                            foreach (var fish in fishes)
                            {
                                Console.WriteLine("Species: " + fish.fishType + "| Age: " + fish.age + " | Sex: " + fish.sex + " | Price: " + fish.price + " | ID: " + fish.Id);
                                    Console.WriteLine(" ");
                                }
                            break;
                        case "4":
                            default:
                                continue1 = false;
                                break;
                    }

                    break;
                    case "2":
                        Console.WriteLine("Adding");
                        break;

                    case "3":
                        Console.WriteLine("Checking");
                        break;

                    case "4":
                    default:
                        continue1 = false;
                        break;
                }
            }
        }
        static void MenuIndex()
        {
            Console.WriteLine("            Menu           | Enter:");
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("- Buy animal:              | (1)   ");
            Console.WriteLine("- Add new animal to store: | (2)   ");
            Console.WriteLine("- Check balance:           | (3)   ");
            Console.WriteLine("- Exit:                    | (4)   ");
        }

        static void MenuBuyAnimal()
        {
            Console.WriteLine("What kind animal would you like to buy?");
            Console.WriteLine("            Menu           | Enter:");
            Console.WriteLine("___________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("- Snakes:                  | (1)   ");
            Console.WriteLine("- Birds:                   | (2)   ");
            Console.WriteLine("- Fish:                    | (3)   ");
            Console.WriteLine("- Go back to menu:         | (4)   ");
        }

        static void PlaceAnimalToChart()
        {
            //
        }
    }
}
