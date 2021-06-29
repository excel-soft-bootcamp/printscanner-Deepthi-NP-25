using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterScannerProblem
{
    class PrintScanner
    {
        IPrinter printer;
        IScanner scanner;

        public PrintScanner(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;

        }
        public void PrintScan()
        {
            printer.Print();
            scanner.Scan();
        }
    
    }

}
