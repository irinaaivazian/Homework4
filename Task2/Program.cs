namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "notebook";
            string str2 = "table";
            string str3 = "chair";
            string str4 = "car";
            string str5 = "window";
            string allstr = str1 + " " + str2 + " " + str3 + " " + str4 + " " + str5;
            Console.WriteLine(allstr);
            Console.WriteLine();
            string allstr1 = string.Concat(str1," ",str2," ",str3," ", str4, " ",str5);
            Console.WriteLine(allstr1);

        }
    }
}
