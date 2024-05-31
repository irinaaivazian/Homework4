namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "apple,banana,orange,kiwi,peach";
            string [] splFruits = fruits.Split(',');
            Console.WriteLine(splFruits[0]);
            Console.WriteLine(splFruits[1]);
            Console.WriteLine(splFruits[2]);
            Console.WriteLine(splFruits[3]);
            Console.WriteLine(splFruits[4]);

        }
    }
}
