namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            
            Console.WriteLine(str1.GetHashCode() == str2.GetHashCode());

        }
    }
}
