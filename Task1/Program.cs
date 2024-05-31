namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            Console.WriteLine(str.Length);

            string upper = str.ToUpper();
            Console.WriteLine(upper);

            string lower = str.ToLower();
            Console.WriteLine(lower);

            string substr = str.Substring(7);
            Console.WriteLine(substr);
        }
    }
}
