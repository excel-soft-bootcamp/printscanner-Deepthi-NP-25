using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProblem
{
    public class PrintManager : IPrinter
    {
        public void Print() 
        { 
            Console.WriteLine("Print in Action");
        }
    }
}
