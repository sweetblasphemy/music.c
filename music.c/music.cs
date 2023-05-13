using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music.c
{
    internal class music
    {

        public string author;
        public double length;
        public string album_name;

        public music(string author, double length, string album_name)
        {

            this.author = author;
            this.length = length;
            this.album_name = album_name;
            Console.WriteLine("The author is: " + author + ", the album's length is: " + length + ", the album's name is: " + album_name);
            
        }
    }
}
