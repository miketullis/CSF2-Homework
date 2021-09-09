using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Book
    {
        //fields 

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        //constructors
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;

        }

        //methods

        public override string ToString()
        {
            return string.Format($"BOOK\n" +
                                 $"====\n" +
                                 $" Title: {Title}\n" +
                                 $"Author: {Author}\n" +
                                 $" Pages: {NumberOfPages}\n");

            //return Title;  
            //only returns title
        }//end ToString()


    }//end class
}//end namespace