namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blogText = "The stack is a region of memory that is used to store local variables and function call information. It is called a “stack” because it behaves like a stack of items, with the most recently added item being the first one to be removed (last in, first out).\r\n\r\nEach time a function is called, a new block of memory is allocated on the stack for that function’s local variables and parameters. When the function returns, this block of memory is deallocated and the stack pointer moves back to the previous function’s block of memory.\r\n\r\nOne important property of the stack is that it is very fast to allocate and deallocate memory from it. This is because the stack has a fixed size and the memory is allocated and deallocated in a last-in, first-out manner";
            {
                string searchWord = "stack";
                bool containsWord = blogText.Contains(searchWord);

                Console.WriteLine(containsWord);

                if (containsWord)
                {
                    List<int> indexPositions = new List<int>();
                    int start = 0;
                    while ((start = blogText.IndexOf(searchWord, start)) != -1)
                    {
                        indexPositions.Add(start);
                        start += searchWord.Length;
                    }
                    Console.WriteLine($"Indexes of the word '{searchWord}': {string.Join(", ", indexPositions)}");
                }
                else
                {
                    Console.WriteLine($"The word '{searchWord}' is not found in the text.");
                }
            }
        }
    }
}
