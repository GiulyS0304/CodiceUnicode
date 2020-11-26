using System;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            //string unicodeString =
            //	 "This unicode string has 2 characters outside the" +
            //     " ASCII range: \n" +
            //	 "Pi (\u03A0), and Sigma (\u03A3)."; 
            string unicodeString = "";
            Console.WriteLine("Inserisci una frase"); // Dico all'utente di inserire una frase da console
            unicodeString = Console.ReadLine(); // Permetto all'utente di inserire una frase a console
            Console.WriteLine("Original String");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
        }
    }
}
