using System;

namespace PrinterScannerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintManager printmanager = new PrintManager();
            ScanManager scanmanager = new ScanManager();
            PrintScanner printscan = new PrintScanner(printmanager, scanmanager);
            printscan.PrintScan();
        }
    }
}
    
    

    
    
    

    