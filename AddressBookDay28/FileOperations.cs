using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBookDay28
{
    public class FileOperations
    {
        public void FileExits()
        {
            string path = @"D:\.net\Day 28 Third Party Libraby\AddressBookDay28\AddressBook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }

        }
       
        
    }
}
