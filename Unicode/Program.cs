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

            // ESEMPIO CHE CONVERTE UN VALORE NUMERICO O ALFANUMERICO IN CODICE ASCII

            //Console.WriteLine("Inserisci un valore numerico o alfanumerico da convertire in codice ASCII");
            //char carattere = Convert.ToChar(Console.ReadLine());

            //int number = carattere;
            //// aggiunge 4 al numero decimale corrispondente della lettera inserita
            //// number = number + 4;

            //Console.WriteLine($"Il carattere digitato nella tabella ASCII cosrrisponde al numero: {number.ToString()}");
            //string binario = Convert.ToString(number, 2).PadLeft(8, '0');

            //Console.WriteLine($"Il carattere in codice binario corrisponde alla sequenza di bit {binario}");
            //Console.ReadKey();

        }
    }
}
