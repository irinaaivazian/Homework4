namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "a";
            string str2 = "";
            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));
            Console.WriteLine(string.IsNullOrWhiteSpace(str1));
            Console.WriteLine(string.IsNullOrWhiteSpace(str2));
        }
    }
}
