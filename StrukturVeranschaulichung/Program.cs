using System;
using System.Diagnostics;
namespace StrukturVeranschaulichung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            WortMenge menge = new();
            menge.GenerateNGeneration(2);
            AnalyzerResult result = Analyzer.Analyze(menge);
            Console.WriteLine(result.ToString());
        }
    }
}