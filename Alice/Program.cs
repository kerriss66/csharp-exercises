using System;

namespace Alice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string searchTerm;
            int indexOfSearchTerm;

            Console.WriteLine(sentence);
            Console.WriteLine("Enter a search term:");
            
            searchTerm = Console.ReadLine();

            indexOfSearchTerm = sentence.IndexOf(searchTerm);

            Console.WriteLine("Was term found? " + (indexOfSearchTerm >= 0));
        }
    }
}
