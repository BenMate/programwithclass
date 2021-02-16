using System;
using System.Collections.Generic;
using System.IO;
namespace AIE_30_SaveContact
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("Bob", "bob@email.com", "12345678"));
            contacts.Add(new Contact("Fred", "", ""));
            contacts.Add(new Contact("Ted", "", "12345678"));

            // save to file
            SerialiseContactList("contacts.txt", contacts);

            // clear them out
            contacts = new List<Contact>();

            // read from file
            DeSerialiseContactList("contacts.txt", contacts);

            foreach (var contact in contacts)
            {
               
                Console.WriteLine($"{contact.name} {contact.email} {contact.phone}");
            }
        }

        static void SerialiseContactList(string filename, List<Contact> contacts)
        {
            // TODO save all contacts to file.
            using (StreamWriter sw = File.CreateText(filename))
            {
                foreach (var contact in contacts)
                {
                    if (!string.IsNullOrWhiteSpace(contact.name))sw.WriteLine("name: " + contact.name);
                    if (!string.IsNullOrWhiteSpace(contact.email))sw.WriteLine("email: " + contact.email);
                    if (!string.IsNullOrWhiteSpace(contact.phone))sw.WriteLine("phone: " + contact.phone);
                    sw.WriteLine("");

                }
            }
        }
        static void DeSerialiseContactList(string filename, List<Contact> contacts)
        {
            //creates the file if the file isnt there.
            var fileInfo = new FileInfo(filename);
            var dir = fileInfo.Directory.FullName;
            Directory.CreateDirectory(dir);

           
            Contact contact = new Contact();
            
            // TODO load all contacts from file.
            using (StreamReader sr = File.OpenText(filename))
            {
                
                string s;
                while ((s = sr.ReadLine()) != null)
                {

                    if (string.IsNullOrEmpty(s))
                    {
                        contacts.Add(contact);

                        contact = new Contact();
                    }
                    
                    else
                    {
                        var entry = s.Split(" ");

                        if (entry[0] == "name:") contact.name = entry[1];
                        if (entry[0] == "email:") contact.email = entry[1];
                        if (entry[0] == "phone:") contact.phone = entry[1];

                        // Console.WriteLine(entry[1]);
                    }                   
                }
            }           
        }
    }
}

