using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF2Homework
{
    public class Album
    {
        //Artist should technically be Ablum

        //fields 

        //properties
        public string Title { get; set; }
        public string Genre { get; set; }
        public List<Song> Tracks { get; set; }


        //constructors

    public Album(string title, string genre, List<Song> tracks)
        {
            Title = title;
            Genre = genre;
            Tracks = tracks;

        }

        //methods




    public override string ToString()
        {
            string albumSongs = "";

            foreach (Song sg in Tracks)
            {
                albumSongs += " - " + sg.Title + "\n";
            }//end foreach
            
            
            return string.Format($"ALBUM INFO\n" +
                                 $"===========\n" +
                                 $" Title: {Title}\n" +
                                 $" Genre: {Genre}\n" +
                                 $" Tracks:\n" +
                                 $"{albumSongs}");

        }//end ToString()


    }//end class
}//end namespace

