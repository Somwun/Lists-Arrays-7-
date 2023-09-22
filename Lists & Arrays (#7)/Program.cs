using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

namespace Lists___Arrays___7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 2, userAdd, userRemove;
            List<int> randomNumbers = new List<int>();
            Random generator = new Random();
            bool repeat = true;
            while (repeat)
            {
                if (userChoice == 2)
                {
                    Console.Clear();
                    randomNumbers.Clear();
                    for (int i = 0; i < 25; i ++)
                    {
                        randomNumbers.Add(generator.Next(10,21));
                        Console.Write(randomNumbers[i] + " ");
                    }
                    newNumbers = false;
                }
                Console.WriteLine("\n\nPick what you'd like to do with the string of numbers above\n(Type the number of the corresponding action)\n1. Sort the list\n2. Regenorate list\n3. Remove one of the numbers\n4. Add a number\n5. Count the numbers\n6. Show the biggest number\n7. Show the smallest number\n8. Show the average number\n9. Show the number that shows up the most\n10. Quit");
                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 11)
                {
                    Console.WriteLine("Not quite, pick something else");
                }
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        randomNumbers.Sort();
                        for (int i = 0; i < randomNumbers.Count(); i++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nPick a number to remove");
                        while (!int.TryParse(Console.ReadLine(), out userRemove) || !randomNumbers.Contains(userRemove))
                        {
                            if (!randomNumbers.Contains(userRemove))
                                Console.WriteLine("That number doesn't exit");
                            else
                                Console.WriteLine("Pick something else");
                        }
                        Console.WriteLine("");
                        while (randomNumbers.Contains(userRemove))
                        {
                            randomNumbers.Remove(userRemove);
                        }
                        Console.Clear();
                        for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Choose a number to add to the list");
                        while (!int.TryParse(Console.ReadLine(), out userAdd))
                        {
                            Console.WriteLine("Not quite, pick something else");
                        }
                        Console.Clear();
                        randomNumbers.Add(userAdd);
                        for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                }
            }
        }
    }
}