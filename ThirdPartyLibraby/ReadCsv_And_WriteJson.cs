using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace ThirdPartyLibraby
{
    public class ReadCsv_And_WriteJson
    {
        public static void ImplementCSVToJson()
        {
            string importFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\address.csv";
            string exportFilePath = @"D:\.net\Day 28 Third Party Libraby\ThirdPartyLibraby\ThirdPartyLibraby\Utility\export.json";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data sucessfull from address.csv file");
                foreach (AddressData addressData in records)
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

                //Writing json
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }



}

