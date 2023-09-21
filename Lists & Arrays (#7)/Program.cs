using static System.Formats.Asn1.AsnWriter;

namespace Lists___Arrays___7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < 25; i ++)
            {
                randomNumbers.Add(generator.Next(10,21));
                Console.Write(randomNumbers[i] + " ");
            }
        }
    }
}