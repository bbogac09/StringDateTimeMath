using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDateTimeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] isimKarakterler = new char[3]
            {
                'C', 'A', 'N'
            };
            foreach (char c in isimKarakterler)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            string isimString = "CAN";
            Console.WriteLine(isimString);

            string city1 = "Ankara";
            Console.WriteLine(city1[0]); //1

            foreach (char c in city1)
            {
                Console.WriteLine(c);
            }

            string city2 = "İstanbul";
            string result1 = city1 + city2; // ---> concetenate Ankaraİstanbul
            string result2 = city1 + " " + city2; // Ankara İstanbul
            string result3 = String.Format("{0} {1}", city1, city2); // Ankara İstanbul

            string sentence = "My name is Çağıl Alsaç";
            int length = sentence.Length; // 22
            sentence = sentence.Replace("Çağıl", "Leo"); //Sentence içindeki Çağılları Leolara çeviricek.
            if (sentence.EndsWith("ç"))
                Console.WriteLine("Sentence ends with ç");
            else
                Console.WriteLine("Sentence doesn't end with ç");

            if (sentence.StartsWith("Your name"))
                Console.WriteLine("Sentence starts with Your name");
            else
                Console.WriteLine("Sentence doesn't starts with Your name");

            int indexOfIs = sentence.IndexOf("is"); // 8
            int indexOfCagil = sentence.IndexOf("çağıl"); // -1

            int indexOfSpace = sentence.IndexOf(" "); // 2
            int lastIndexOfSpace = sentence.LastIndexOf(" "); // 14

            Console.WriteLine(indexOfSpace + " - " + lastIndexOfSpace);

            sentence = "Hello!" + sentence;
            //sentence.Insert(0, "Hello! "); 

            string subSentence = sentence.Substring(0, 6); //Hello! 'yu yazdırır.
            Console.WriteLine(subSentence);
            subSentence = sentence.Substring(18); // Leo Alsaç
            subSentence = sentence.Substring(7, 14); // My name is Leo

            //Hello! My name is Leo Alsaç
            Console.WriteLine("Lower: " + sentence.ToLower());
            Console.WriteLine("Upper: " + sentence.ToUpper());
            Console.WriteLine(sentence.Replace(" ", "_"));

            //Hello! My name is Leo Alsaç
            sentence = sentence.Remove(0, 7); // My name is Leo Alsaç

            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(words[3]); // Leo

            string test1 = "test1";
            string test2 = "test2";
            if (test1 == test2)
                Console.WriteLine("test1 = test2");
            else
                Console.WriteLine("test1 != test2");

            if (test1.Equals(test2))
                Console.WriteLine("test1 = test2");
            else
                Console.WriteLine("test1 != test2");

            string adSoyad = " Çağıl Alsaç ";
            Console.WriteLine("\"" + adSoyad + "\"");
            Console.WriteLine("\"" + adSoyad.Trim() + "\""); //Trim başındaki ve sonundaki boşlukları traşlar.
            Console.WriteLine("\"" + adSoyad.TrimStart() + "\""); //Başındakileri
            Console.WriteLine("\"" + adSoyad.TrimEnd() + "\""); //Sonundakileri
            Console.WriteLine(adSoyad.Contains("ğ") ? "ğ var" : "ğ yok");



            Console.ReadLine();
        }
    }
}
