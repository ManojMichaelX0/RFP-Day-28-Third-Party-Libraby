using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace AddressBookDay28
{
    public class Program
    {
        public string firstName, lastName, address, city, state, zip, phoneNumber, email;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Program p = new Program();
            Dictionary<int, string> addressBook = new Dictionary<int, string>();
            Dictionary<int, string> addressBook2 = new Dictionary<int, string>();


            Choice();
            void Choice()
            {
                Console.WriteLine("\nEnter 1 for Add Details");
                Console.WriteLine("Enter 2 for uc 2 and uc 7 Add new Details");
                Console.WriteLine("Enter 3 for Edit Details");
                Console.WriteLine("Enter 4 for Delete Details");
                Console.WriteLine("Enter 5 for Add 3rd Person Details");
                Console.WriteLine("Enter 6 for Add new AddressBook Details");
                Console.WriteLine("Entre 7 for UC 8 and UC 9 Search Person Based on City or State");
                Console.WriteLine("Enter 8 for Uc 10 Count city or state");
                Console.WriteLine("Enter 9 for Sorting");
                Console.WriteLine("Enter 10 for Read and Write AddressBook");
                Console.WriteLine("Enter 11 for Read and Write AddressBook to CSV file");
                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Uc 1 Add Details ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(0, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(1, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(2, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(3, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(4, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(5, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(6, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(7, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[0] + "\nLast Name : " + addressBook[1] + "\nAddress : " + addressBook[2] + "\nCity : " + addressBook[3] + "\nState : " + addressBook[4] + "\nZip : " + addressBook[5] + "\nPhone Number : " + addressBook[6] + "\nEmail : " + addressBook[7]);
                        break;
                    case 2:
                        Console.WriteLine("Uc 2 Enter Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(8, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(9, p.lastName);
                        DuplicateSearch(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(10, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(11, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(12, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(13, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(14, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(15, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[8] + "\nLast Name : " + addressBook[9] + "\nAddress : " + addressBook[10] + "\nCity : " + addressBook[11] + "\nState : " + addressBook[12] + "\nZip : " + addressBook[13] + "\nPhone Number : " + addressBook[14] + "\nEmail : " + addressBook[15]);
                        break;
                    case 3:
                        Console.WriteLine("UC 3 Enter first Name and Last Name of Person to Edit Their Record");
                        string fname = Console.ReadLine();
                        string lname = Console.ReadLine();
                        Check(fname, lname);
                        break;
                    case 4:
                        Console.WriteLine("UC 4 Enter first Name and Last Name of Person to Edit Their Record");
                        string fname1 = Console.ReadLine();
                        string lname1 = Console.ReadLine();
                        Delete(fname1, lname1);
                        break;
                    case 5:
                        Console.WriteLine("UC 5 Add Details ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(16, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(17, p.lastName);
                        DuplicateSearch2(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(18, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(19, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(20, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(21, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(22, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(23, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[16] + "\nLast Name : " + addressBook[17] + "\nAddress : " + addressBook[18] + "\nCity : " + addressBook[19] + "\nState : " + addressBook[20] + "\nZip : " + addressBook[21] + "\nPhone Number : " + addressBook[22] + "\nEmail : " + addressBook[23]);
                        break;
                    case 6:
                        Console.WriteLine("Uc 6 new Addres Book ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook2.Add(0, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook2.Add(1, p.lastName);
                        DuplicateSearch(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook2.Add(2, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook2.Add(3, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook2.Add(4, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook2.Add(5, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook2.Add(6, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook2.Add(7, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook2[0] + "\nLast Name : " + addressBook2[1] + "\nAddress : " + addressBook2[2] + "\nCity : " + addressBook2[3] + "\nState : " + addressBook2[4] + "\nZip : " + addressBook2[5] + "\nPhone Number : " + addressBook2[6] + "\nEmail : " + addressBook2[7]);
                        break;
                    case 7:
                        Console.WriteLine("Enter City");
                        string searchCity = Console.ReadLine();
                        SearchCity(searchCity);
                        SearchCity2(searchCity);
                        Console.WriteLine("Enter State ");
                        string searchState = Console.ReadLine();
                        SearchState(searchState);
                        SearchState2(searchState);
                        break;
                    case 8:
                        Console.WriteLine("Count of City and State in Address Book 1 and Book 2");
                        Console.WriteLine("Enter City ");
                        string countCity = Console.ReadLine();
                        int count = addressBook.Count(kv => kv.Value.Contains(countCity));
                        Console.WriteLine("Count value of given city in Address Book 1:" + count);
                        count = addressBook2.Count(kv => kv.Value.Contains(countCity));
                        Console.WriteLine("Count value of given city in Address Book 2:" + count);
                        Console.WriteLine("Enter State");
                        string countState = Console.ReadLine();
                        count = addressBook.Count(kv => kv.Value.Contains(countState));
                        Console.WriteLine("Count value of given State in Address Book 1:" + count);
                        count = addressBook2.Count(kv => kv.Value.Contains(countState));
                        Console.WriteLine("Count value of given State in Address Book 2:" + count);
                        break;
                    case 9:
                        Console.WriteLine("Sorting AddressBook 1");
                        foreach (KeyValuePair<int, string> address in addressBook.OrderBy(value => value.Value))
                        {
                            Console.WriteLine("Key:{0}, Value {1}", address.Key, address.Value);
                        }
                        Console.WriteLine("Sorting AddressBook 2");
                        foreach (KeyValuePair<int, string> address in addressBook2.OrderBy(value => value.Value))
                        {
                            Console.WriteLine("Key:{0}, Value {1}", address.Key, address.Value);
                        }
                        break;
                    case 10:
                        Console.WriteLine("Checking if File exists");
                        FileOperations fo = new FileOperations();
                        Console.WriteLine("\nChecking if File Exists or Not");
                        fo.FileExits();

                        Console.WriteLine("Reading and Writing Address Book 1");
                        string txt = String.Join(Environment.NewLine, addressBook.Select(d => $"{d.Key};{d.Value};"));
;                       string pathToTXT = @"D:\.net\Day 28 Third Party Libraby\AddressBookDay28\AddressBook.txt";
                        File.WriteAllText(pathToTXT, txt);


                        Console.WriteLine("Reading and Writing Address Book 2");
                        string txt2 = String.Join(Environment.NewLine, addressBook2.Select(d => $"{d.Key};{d.Value};"));
                        ; string pathToTXT2 = @"D:\.net\Day 28 Third Party Libraby\AddressBookDay28\AddressBook.txt";
                        File.WriteAllText(pathToTXT2, txt2); 

                        string[] lines;
                        lines = File.ReadAllLines(pathToTXT);
                        foreach (var l in lines)
                        {
                            Console.WriteLine(l);
                        }
                        break;
                    case 11:
                        Console.WriteLine("Reading and Writing to Csv File Address Book 1");
                        string csv = String.Join(Environment.NewLine, addressBook.Select(d => $"{d.Key};{d.Value};"));
                        string pathTocsv = @"D:\.net\Day 28 Third Party Libraby\AddressBookDay28\AddressBookCSV.csv";
                        File.WriteAllText(pathTocsv, csv);
                        Console.WriteLine("Reading and Writing to Csv File Address Book 2");
                        string csv2 = String.Join(Environment.NewLine, addressBook2.Select(d => $"{d.Key};{d.Value};"));
                        File.WriteAllText(pathTocsv, csv2);                        
                        string[] lines2;
                        lines2 = File.ReadAllLines(pathTocsv);
                        foreach (var l in lines2)
                        {
                            Console.WriteLine(l);
                        }
                        break;
                }
                Choice();
                void Check(string fname, string lname)
                {
                    if (addressBook[0].Equals(fname) && addressBook[1].Equals(lname))
                    {
                        Console.WriteLine("Enter Detail for Updating Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[0] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[1] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[2] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[3] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[4] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[5] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[6] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[7] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[0] + "\nLast Name : " + addressBook[1] + "\nAddress : " + addressBook[2] + "\nCity : " + addressBook[3] + "\nState : " + addressBook[4] + "\nZip : " + addressBook[5] + "\nPhone Number : " + addressBook[6] + "\nEmail : " + addressBook[7]);

                    }
                    else if (addressBook[8].Equals(fname) && addressBook[9].Equals(lname))
                    {
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[8] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[9] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[10] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[11] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[12] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[13] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[14] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[15] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[8] + "\nLast Name : " + addressBook[9] + "\nAddress : " + addressBook[10] + "\nCity : " + addressBook[11] + "\nState : " + addressBook[12] + "\nZip : " + addressBook[13] + "\nPhone Number : " + addressBook[14] + "\nEmail : " + addressBook[15]);

                    }
                    else if (addressBook[16].Equals(fname) && addressBook[17].Equals(lname))
                    {
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[16] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[17] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[18] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[19] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[20] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[21] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[22] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[23] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[16] + "\nLast Name : " + addressBook[17] + "\nAddress : " + addressBook[18] + "\nCity : " + addressBook[19] + "\nState : " + addressBook[20] + "\nZip : " + addressBook[21] + "\nPhone Number : " + addressBook[22] + "\nEmail : " + addressBook[23]);

                    }

                    else if (addressBook2[0].Equals(fname) && addressBook2[1].Equals(lname))
                    {
                        Console.WriteLine("Enter Detail for Updating Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook2[0] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook2[1] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook2[2] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook2[3] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook2[4] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook2[5] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook2[6] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook2[7] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook2[0] + "\nLast Name : " + addressBook2[1] + "\nAddress : " + addressBook2[2] + "\nCity : " + addressBook2[3] + "\nState : " + addressBook2[4] + "\nZip : " + addressBook2[5] + "\nPhone Number : " + addressBook2[6] + "\nEmail : " + addressBook2[7]);
                    }
                    else
                    {
                        Console.WriteLine("Search Name is Not in Records");
                    }
                }
                void Delete(string fname1, string lname1)
                {
                    if (addressBook[0].Equals(fname1) && addressBook[1].Equals(lname1))
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            addressBook.Remove(i);

                        }
                        Console.WriteLine("Record Deleted!");
                    }
                    else if (addressBook[8].Equals(fname1) && addressBook[9].Equals(lname1))
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            addressBook.Remove(i);

                        }
                        Console.WriteLine("Record Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Given Person Details Does Not Exists");
                    }
                }
                void DuplicateSearch(string fname, string lname)
                {
                    if (addressBook[0].Equals(addressBook[8]) && addressBook[1].Equals(addressBook[9]))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                        Choice();
                    }

                }
                void DuplicateSearch2(string fname, string lname)
                {
                    if (addressBook[0].Equals(addressBook[16]) && addressBook[1].Equals(addressBook[17]))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                        Choice();
                    }


                    if (addressBook[8].Equals(addressBook[16]) && addressBook[9].Equals(addressBook[17]))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                        Choice();
                    }


                }
                void SearchCity(string searchValue)
                {
                    Console.WriteLine("Person Detials in book 1 in this City are :\n");

                    if (addressBook.All(e => (addressBook[3].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[0]);
                    }
                    if (addressBook.All(e => (addressBook[11].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[8]);
                    }
                    if (addressBook.All(e => (addressBook[19].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[16]);
                    }
                }



                void SearchCity2(string searchValue)
                {
                    Console.WriteLine("Person Detials in book 2 in this City are :\n");
                    if (addressBook2.All(e => (addressBook2[3].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook2[0]);
                    }


                }
                void SearchState(string searchValue)
                {
                    Console.WriteLine("Person Detial in book 1 in this State are :\n");
                    int i = 0;
                    if (addressBook.All(e => (addressBook[4].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[0]);
                    }
                    if (addressBook.All(e => (addressBook[12].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[8]);
                    }
                    if (addressBook.All(e => (addressBook[20].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook[16]);
                    }

                }
                void SearchState2(string searchValue)
                {
                    Console.WriteLine("Person Detial in book 2 in this City are :\n");
                    int j = 0;
                    if (addressBook2.All(e => (addressBook2[4].Equals(searchValue))))
                    {
                        Console.WriteLine(addressBook2[j]);
                    }


                }
                

               

            }

        }
    }
}




