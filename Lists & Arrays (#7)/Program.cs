using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

namespace Lists___Arrays___7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 2, userAdd, userRemove, userCount, userCountAmount = 0;
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
                }
                Console.WriteLine("\n\nPick what you'd like to do with the string of numbers above\n(Type the number of the corresponding action)\n1. Sort the list\n2. Regenorate list\n3. Remove one of the numbers\n4. Add a number\n5. Count occurance of numbers\n6. Show the biggest number\n7. Show the smallest number\n8. Show the average number\n9. Show the number that shows up the most\n10. Quit");
                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 11)
                {
                    Console.WriteLine("Not quite, pick something else");
                }
                switch (userChoice)
                {
                    /* For copy pasting
for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                    */

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
                        for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
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
                        for (int i = 0; i < randomNumbers.Count(); i++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        Console.WriteLine("\nChoose a number to add to the list");
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
                        Console.Clear();
                        for (int i = 0; i < randomNumbers.Count(); i++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        Console.WriteLine("\nPick a number from the list and I'll tell you how many times it shows up");
                        while (!int.TryParse(Console.ReadLine(), out userCount) || !randomNumbers.Contains(userCount))
                        {
                            if (!randomNumbers.Contains(userCount))
                                Console.WriteLine("That number doesn't exist");
                            else
                                Console.WriteLine("Nope, try again");
                        }
                        for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            if (randomNumbers[i] == userCount)
                                userCountAmount += 1;
                        }
                        randomNumbers.Count();
                        if (userCountAmount == 1)
                            Console.WriteLine($"{userCount} shows up 1 time in the list\n(Press enter to continue)");
                        else
                            Console.WriteLine($"{userCount} shows up {userCountAmount} times in the list\n(Press enter to continue)");
                        userCountAmount = 0;
                        Console.ReadLine();
                        Console.Clear();
                        for (int i = 0; i < randomNumbers.Count(); i ++)
                        {
                            Console.Write(randomNumbers[i] + " ");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"The largest number in the list is {randomNumbers.Max()}\n(Press enter to continue)");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine($"The smallest number in the list is {randomNumbers.Min()}\n(Press enter to continue)");
                        Console.ReadLine();
                        break;
                    case 8:
                        //Average the numbers
                        break;
                    case 9:
                        //Find the most occuring value
                        break;
                    case 10:
                        repeat = false;
                        break;
                }
            }
        }
    }
}