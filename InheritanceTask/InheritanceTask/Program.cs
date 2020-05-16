using System;
using System.Globalization;

namespace InheritanceTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string keyWord = Console.ReadLine();
            if (keyWord == "basic")
            {
                DocumentProgram program = new DocumentProgram();
                program.OpenDocument();
                program.EditDocument();
                program.SaveDocument();

            }
            else if(keyWord == "pro")
            {
                DocumentProgram program = new ProDocumentProgram();
                program.OpenDocument();
                program.EditDocument();
                program.SaveDocument();
            }
            else if (keyWord == "expert")
            {
                DocumentProgram program = new ExpertDocument();
                program.OpenDocument();
                program.EditDocument();
                program.SaveDocument();
            }


        }
    }

    class DocumentProgram
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }

    class ProDocumentProgram : DocumentProgram
    {
        public override sealed void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }

    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
