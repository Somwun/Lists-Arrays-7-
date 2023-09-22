using static System.Formats.Asn1.AsnWriter;

namespace Lists___Arrays___7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userRemove, userChoice;
            List<int> randomNumbers = new List<int>();
            Random generator = new Random();
            bool repeat = true, newNumbers = true, menuOn = true, sort = false;
            while (repeat)
            {
                if (newNumbers)
                {
                    for (int i = 0; i < 25; i ++)
                    {
                        randomNumbers.Add(generator.Next(10,21));
                        Console.Write(randomNumbers[i] + " ");
                    }
                    newNumbers = false;
                }
                while (menuOn)
                {
                    Console.WriteLine("\n\nPick what you'd like to do with the string of numbers above\nType the number of the corresponding action\n1. Sort the list\n2. Regenorate list\n3. Remove one of the numbers\n4. Add a number\n5. Count the numbers\n6. Show the biggest number\n7. Show the smallest number\n8. Show the average number\n9. Show the number that shows up the most\n10. Quit");
                    while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 11)
                    {
                        Console.WriteLine("Not quite, pick something else");
                    }
                    switch(userChoice)
                    {
                        case 1:

                            break;
                            break;
                        case 2:

                            break;
                            break;
                        case 3:

                            break;
                            break;
                        case 4:

                            break;
                            break;
                        case 5:

                            break;
                            break;
                        case 6:

                            break;
                            break;
                        case 7:

                            break;
                            break;
                        case 8:

                            break;
                        case 9:

                            break;
                            break;
                        case 10:

                            break;
                            break;
                    }
                }
                Console.WriteLine("");
                randomNumbers.Sort();
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(randomNumbers[i] + " ");
                }
                Console.WriteLine("\nPick a number to remove");
                while (!int.TryParse(Console.ReadLine(), out userRemove) || userRemove < 10 || userRemove > 20)
                {
                    Console.WriteLine("Pick something else");
                }
                Console.WriteLine("");
                while (randomNumbers.Contains(userRemove))
                {
                    randomNumbers.Remove(userRemove);
                }
                for (int i = 0; i < randomNumbers.Count(); i ++)
                {
                    Console.Write(randomNumbers[i] + " ");
                }
            }

        }
    }
}