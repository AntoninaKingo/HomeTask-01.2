using System;

namespace HomeTask_01._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string myText = Console.ReadLine();

            char[] splitted = myText.ToCharArray();
            int[] notSorted = new int[3];
            notSorted[0] = int.Parse(splitted[0].ToString());
            notSorted[1] = int.Parse(splitted[1].ToString());
            notSorted[2] = int.Parse(splitted[2].ToString());

            Array.Sort(notSorted);
            Console.WriteLine($"{notSorted[2]}{notSorted[1]}{notSorted[0]}");
        }
    }
}