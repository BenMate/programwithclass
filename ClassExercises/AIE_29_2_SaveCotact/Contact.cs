using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AIE_29_2_SaveCotact
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

            //create diractory
            var fileInfo = new FileInfo(filename);
            Directory.CreateDirectory(fileInfo.Directory.FullName);

            // TODO: use StreamWriter to write the name, email and phone to file
            using (StreamWriter sw = File.CreateText(filename))
            {
                if (!string.IsNullOrWhiteSpace(name)) sw.WriteLine("name: " + name);
                if (!string.IsNullOrWhiteSpace(email)) sw.WriteLine("email: " + email);
                if (!string.IsNullOrWhiteSpace(phone)) sw.WriteLine("phone: " + phone);
                
            }
            
        }

        public void DeSerialise(string filename)
        {
            // TODO: use StreamReader to write the name, email and phone to file

            using (StreamReader sr = File.OpenText(filename))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var entry = line.Split(" ");

                    if (entry[0] == "name") name = entry[1];
                    if (entry[0] == "email") email = entry[1];
                    if (entry[0] == "phone") phone = entry[1];

                }

            }
        }

        public void Print()
        {
            Console.WriteLine($"{name} {email} {phone}");
        }
    }
}
