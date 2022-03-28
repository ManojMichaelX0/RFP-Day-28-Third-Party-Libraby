using System;

namespace ThirdPartyLibraby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Third Party Libraby ");
            //Console.WriteLine("# Read Data for Csv File $ Write Data into Another CSv File");
            //csvHandler.ImplementCSVDataHandling();
            //Console.WriteLine();

            //Console.WriteLine("# Read data From Csv and Writing into Json File");
            ////Read
            //ReadCsv_And_WriteJson.ImplementCSVToJson();
            //Console.WriteLine();

            Console.WriteLine("#Read data from Json and Write it to Csv");
            //read from json and write to csv
            ReadingJSONAndWrtingTOCSV.ImplementJsontoCsv();
            Console.WriteLine();
        }
    }
}
