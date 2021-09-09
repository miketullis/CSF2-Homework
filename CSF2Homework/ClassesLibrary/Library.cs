using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Library
    { 
        //fields 
        

        //properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //();

        //constructors
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;

        }

        //methods
        public override string ToString()
        {

            string libBooks = "";
            
            foreach (Book b in Books)
            {
                libBooks += " - " + b.Title + "\n";
            }//end foreach
             

            return string.Format($"LIBRARY\n" +
                                 $"=======\n" +
                                 $"   Name: {LibraryName}\n" +
                                 $"Address: {StreetAddress}\n" +
                                 $"   City: {City}\n" +
                                 $"  State: {State}\n" +
                                 $"    Zip: {Zip}\n\n" +
                                 $"Books Available: \n" +
                                 $"{libBooks}\n");
            
        }//end ToString()


    }//end class
}//end namespace