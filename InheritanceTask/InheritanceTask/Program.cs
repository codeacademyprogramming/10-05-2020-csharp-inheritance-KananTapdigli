using System;
using System.Globalization;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string keyword;

            do
            {
                Console.WriteLine("Please enter keyword: ");
                keyword = Console.ReadLine();

                if (keyword == "basic")
                {
                    DocumentProgram docProgram = new DocumentProgram();

                    docProgram.OpenDocument();
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                }

                else if (keyword == "pro")
                {
                    DocumentProgram docProgram = new ProDocumentProgram();

                    docProgram.OpenDocument();
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                }

                else if (keyword == "expert")
                {
                    DocumentProgram docProgram = new ExpertDocument();

                    docProgram.OpenDocument();
                    docProgram.EditDocument();
                    docProgram.SaveDocument();
                }
                else
                {
                    Console.WriteLine("It is not correct keyword");
                }
            } while (!(keyword == "basic" || keyword == "pro" || keyword == "expert"));

        }
    }
 
}
