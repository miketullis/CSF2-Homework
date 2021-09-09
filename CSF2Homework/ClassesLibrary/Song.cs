using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Song
    {
        //fields 

        //properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        //constructors
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }

        //methods

        public override string ToString()
        {
            return string.Format($"SONG\n" +
                                 $"====\n" +
                                 $"Artist: {Artist}\n" +
                                 $" Title: {Title}\n" +
                                 $"Length: {LengthInSeconds} secs\n");

        }//end ToString()
    }//end class
}//end namespace

