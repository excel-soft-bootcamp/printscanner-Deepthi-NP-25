using System;
using System.Collections.Generic;
using System.Text;

namespace PrintScannerProblem
{
    public class ScanManager 
    {
        public void ScanDocument(IScanner scanner)
        {
            scanner.Scan();
        }
    }
}
