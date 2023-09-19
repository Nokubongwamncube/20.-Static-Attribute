using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            songs song1 = new songs("Holiday", "Green Day", 115);
            songs song2 = new songs("Billy Jeans", "MJ", 200);
            Console.WriteLine(song1.title);
            Console.WriteLine(songs.songcount);

            //frezze
            Console.Read();



        }
    }
}
