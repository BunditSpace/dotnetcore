using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassLibraryISBN.ISBN iSBN = new ClassLibraryISBN.ISBN();
            string isbn = " 0-321-14653-0";
            bool isValid = iSBN.IsValidISBN(isbn);
            Console.WriteLine("Check isbn 10 : " + isbn + " Result Isvalid : " + isValid);

            string isbn2 = " 0-321-14653-3";
            isValid = iSBN.IsValidISBN(isbn2);
            Console.WriteLine("Check isbn 10 : " + isbn2 + " Result Isvalid : " + isValid);
            Console.ReadLine();
        }
    }
}
