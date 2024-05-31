namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = new string('T',3);
            Console.WriteLine(ReferenceEquals(str1,str2));
            Console.WriteLine(ReferenceEquals(str1, str3));
        }
    }
}
