using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
