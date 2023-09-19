using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_Attribute
{
    class songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songcount; //declared a atatic attribute

        public songs(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songcount++;


        

                

        }




   


    }
}
