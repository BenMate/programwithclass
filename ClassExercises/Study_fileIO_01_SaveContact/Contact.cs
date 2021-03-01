using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Study_fileIO_01_SaveContact
{
    class Contact
    {
        public string name = "";
        public string email = "";
        public string phone = "";

        public Contact()
        {

        }

        public Contact(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public void Serialise(string filename)
        {
            
            //creates file if it doesnt exit
            var fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);
            //todo: use StreamWriter to write the name, email and phone to fill

            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine(name);
                sw.WriteLine(email);
                sw.WriteLine(phone);

            }



        }

        public void DeSerialise(string filename)
        {
            //todo: use StreamReader to write the name, email and phone to fill

            using (StreamReader sr = File.OpenText(filename))
            {

                name = sr.ReadLine();
                email = sr.ReadLine();
                phone = sr.ReadLine();

            }

        }
        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }

    }
}
