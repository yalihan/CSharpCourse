using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Alihan Yılmaz";
            int lengthSentence = sentence.Length;
            var cloneSentence = sentence.Clone();
            sentence = "My name is Alihan";

            bool ends = sentence.EndsWith("n");
            bool starts = sentence.StartsWith("M");

            int indexOf = sentence.IndexOf("name");
            int indexOfSpice = sentence.IndexOf(" ");
            int indexOfLastSpice = sentence.LastIndexOf(" ");
            int indexOfNone = sentence.IndexOf("");
            string inserting = sentence.Insert(0, "Hello, ");
            string substringing = sentence.Substring(3);
            string substringingAdvance = sentence.Substring(3, 4);
            string toLower = sentence.ToLower();
            string toUpper = sentence.ToUpper();
            string replacing = sentence.Replace("a", "b");
            string removing = sentence.Remove(2);
            string removingAdvance = sentence.Remove(2, 4);

            Console.WriteLine("Clone of Sentence : " + cloneSentence);
            Console.WriteLine("Sentence : " + sentence);
            Console.WriteLine("\nLower Sentence : " + toLower);
            Console.WriteLine("Upper Sentence : " + toUpper);
            Console.WriteLine("\nReplace a to b : " + replacing);
            Console.WriteLine("\nRemove from 2 : " + removing);
            Console.WriteLine("Remove from 2 to 4 : " + removingAdvance);
            Console.WriteLine("\nInserted Sentence : " + inserting);
            Console.WriteLine("\nSubstring of Sentence right of third index : " + substringing);
            Console.WriteLine("Substring of Sentence right of third index with four character : " + substringingAdvance);

            Console.WriteLine("\nIndex of None : " + indexOfNone);
            Console.WriteLine("Index of Spice : " + indexOfSpice);
            Console.WriteLine("Index of Last Spice : " + indexOfLastSpice);
            Console.WriteLine("\nEnd : " + ends+"\nStart : "+starts);
            Console.ReadLine();
        }
        private static void Intro(string[] args)
        {
            string city1 = "Ankara";
            
            foreach(var character in city1)
            {
                Console.Write(character);
            }
            
            Console.WriteLine("\n"+city1);

            string city2 = "İstanbul";
            string result = city1 + city2;
            Console.WriteLine("{0} {1}", city1, city2);
            Console.ReadLine();
        }
    }
}
