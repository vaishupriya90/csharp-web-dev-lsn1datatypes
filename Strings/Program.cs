using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            string input;
            int indexOfWord;
            int lengthOfWord;
            //bool searchResult;
            sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had " +
                "peeped into the book her sister was reading, but it had no pictures " +
                "or conversations in it, 'and what is the use of a book,' thought Alice 'without " +
                "pictures or conversation?'";
            string updatedSentence;
            sentence = sentence.ToLower();
            Console.WriteLine("Enter the word to be searched:");
            input = Console.ReadLine();
            input = input.ToLower();
            indexOfWord = sentence.IndexOf(input);
            lengthOfWord = input.Length;
            if (sentence.Contains(input))
            {
                Console.WriteLine("search result is: " + true);
                Console.WriteLine("Index of the word is " + indexOfWord + " and Length of the word is " + lengthOfWord);
                //updatedSentence = sentence.Remove(indexOfWord, lengthOfWord);
                sentence = sentence.Remove(indexOfWord, lengthOfWord);
                Console.WriteLine(sentence);

            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine(sentence);
        }
    }
}
