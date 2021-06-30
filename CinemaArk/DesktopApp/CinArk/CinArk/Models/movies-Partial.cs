using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinArk.Models
{
    partial class movies
    {
        public movies(string title, string genre, string rating, string lenght, string release_date, int room, byte[] img)
        {
            this.title = title;
            this.genre = genre;
            this.rating = rating;
            this.lenght = lenght;
            this.release_date = release_date;
            this.room = room;
            this.img = img;
        }

        public movies()
        {
            this.title = title;
            this.genre = genre;
            this.rating = rating;
            this.lenght = lenght;
            this.release_date = release_date;
            this.room = room;
            this.img = img;
        }
    }
}
