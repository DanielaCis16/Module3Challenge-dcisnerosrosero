using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());
            //If-else statements
            if (hungerLevel >= 8)
            {
                Console.WriteLine("Lion: Roar! I need a big meal.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
            }
            else
            {
                Console.WriteLine("Tortoise: Slow and steady-I'll have some lettuce.");
            }//end of if-else

            //Ternary operator
            string animalSound = (hungerLevel >= 8) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
            Console.WriteLine(animalSound);
            
            //Switch statement 
            Console.Write("Enter a number from 1 to 7 (1 = Sunday, 2 = Monday, ..., 7 = Saturday):");
            int dayOfWeek = int.Parse(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Lion's Roar Sunday");
                    break;
                case 2:
                    Console.WriteLine("Tortoise Monday: Slow and steady wins the race—pace yourself.");
                    break;
                case 3:
                    Console.WriteLine("Lazy Tuesday: 2x1 if you are wearing pajamas");
                    break;
                case 4:
                    Console.WriteLine("Monkey Wednesday: Free coffee or snack for anyone who wears animal print.");
                    break;
                case 5:
                    Console.WriteLine("Penguin Thursday: Invite people to wear black & white");
                    break;
                case 6:
                    Console.WriteLine("Snake Friday: Slithering into weekend mode—10% off");
                    break;
                case 7:
                    Console.WriteLine("Tiger Saturday: Free tiger-themed stickers for everyone!");
                    break;
                default:
                    Console.WriteLine("Hey! That's not a day of the week.");
                    break;
            }//end of Switch
        } //end of Main
    } //end of class Program
} //end of namespace