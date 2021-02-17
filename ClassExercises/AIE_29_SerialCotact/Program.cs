using System;

namespace AIE_29_SerialCotact
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact person1 = new Contact("bob", "bobTheBuilder@email.com", "12345678");
            Contact person2 = new Contact("fred", "FredFromBuffy@email.com", "12345678");
            Contact person3 = new Contact("ted", "TeddyBear@email.com", "12345678");

            // write each contact to file
            person1.Serialise("./Contacts/bob.txt");
            person2.Serialise("./Contacts/fred.txt");
            person3.Serialise("./Contacts/ted.txt");


            // lets clear out the "contact" and load it back in from file
            person1 = new Contact();
            person2 = new Contact();
            person3 = new Contact();

            person1.DeSerialise("./Contacts/bob.txt");
            person2.DeSerialise("./Contacts/fred.txt");
            person3.DeSerialise("./Contacts/ted.txt");

            person1.Print();
            person2.Print();
            person3.Print();
        }
    }
}
