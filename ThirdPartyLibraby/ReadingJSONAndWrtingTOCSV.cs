using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

namespace ThirdPartyLibraby
{
    internal class ReadingJSONAndWrtingTOCSV
    {
        public static void ImplementJsontoCsv()
        {
            string importFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\export.json";
            string exportFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\JsontoCsv.csv";

            IList<AddressData> addresses = JsonConvert.DeserializeObject<List<AddressData>>(File.ReadAllText(importFilePath));

            foreach (AddressData addressData in addresses)
            {
                Console.Write("\t" + addressData.firstName);
                Console.Write("\t" + addressData.lastName);
                Console.Write("\t" + addressData.address);
                Console.Write("\t" + addressData.city);
                Console.Write("\t" + addressData.state);
                Console.Write("\t" + addressData.zipcode);
                Console.Write("\n");

            }
            Console.WriteLine("Reading From Json and Writing to csv");
            //writing to csv file

            using (var writer = new StreamWriter(exportFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(addresses);
            }
        }
    }
}
