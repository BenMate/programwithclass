using System;

namespace Study_fileIO_01_SaveContact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact person1 = new Contact("bob", "bob@email.com", "123456789");
            Contact person2 = new Contact("fred", "fred@email.com", "123456789");
            Contact person3 = new Contact("ted", "ted@email.com", "123456789");

            //write each contact to file
            person1.Serialise("./contacts/bob.txt");
            person2.Serialise("./contacts/bob.txt");
            person3.Serialise("./contacts/bob.txt");

            //lets clear out the "contact" and load it back in from file
            person1 = new Contact();
            person2 = new Contact();
            person3 = new Contact();

            person1.DeSerialise("./contacts/bob.txt");
            person2.DeSerialise("./contacts/fred.txt");
            person3.DeSerialise("./contacts.ted.txt");

            person1.Print();
            person2.Print();
            person3.Print();


        }
    }
}
