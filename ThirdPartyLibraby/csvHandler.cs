using System;
using System.Linq;
using System.IO;
using System.Globalization;
using CsvHelper;

namespace ThirdPartyLibraby
{
    public class csvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\address.csv";
            string exportFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\export.csv";

            //reading csv file
            using (var reader = new StreamReader(importFilePath)) 
            using (var csv  = new CsvReader(reader , CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data sucessfull from address.csv file");
                foreach(AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstName);
                    Console.Write("\t" + addressData.lastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.zipcode);
                    Console.Write("\n");

                }
                Console.WriteLine("\n *******************Now Reading form csv file  and write to csv file ***********");

                //Writing csv
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }

            }
        }
    }
}
