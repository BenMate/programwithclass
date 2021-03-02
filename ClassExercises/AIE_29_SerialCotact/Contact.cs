using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AIE_29_SerialCotact
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
                    sw.WriteLine(name);
                    sw.WriteLine(email);
                    sw.WriteLine(phone);
                }
            
        }

        public void DeSerialise(string filename)
        {          
                // TODO: use StreamReader to read the name, email and phone to file
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
