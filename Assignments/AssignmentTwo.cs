namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence with more than 2 words:");
            string userInput = Console.ReadLine();
            string[] words = userInput.ToLower().Split(); // Note the "ToLower()"
            string word1 = words[0];
            string word2 = words[1];
            string word3 = words[2];

            string firstWordContainsI = word1.Contains('i').ToString().ToUpper();
            string secondWordContainsI = word2.Contains('i').ToString().ToUpper();
            string thirdWordContainsI = word3.Contains('i').ToString().ToUpper();
            // Alternatively: 
            // string firstWordContainsI = Convert.ToString(word1.Contains('i')).ToUpper();
            // string secondWordContainsI = Convert.ToString(word2.Contains('i')).ToUpper();
            // string thirdWordContainsI = Convert.ToString(word3.Contains('i')).ToUpper();

            Console.WriteLine($"{"Word",-15}{"Contains the letter 'i'",-25}");
            Console.WriteLine($"{word1,-15}{firstWordContainsI,-25}");
            Console.WriteLine($"{word2,-15}{secondWordContainsI,-25}");
            Console.WriteLine($"{word3,-15}{thirdWordContainsI,-25}");
        }
    }
}
