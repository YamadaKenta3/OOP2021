using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = new Song[]
            {
                new Song("Battle Battle Battle","摩天狼、FlingPosse",246),
                new Song("Death Respect","摩天狼、FlingPosse",276),
                new Song("Hoodstar","摩天狼、FlingPosse,バスブロ,MTC",246),


            };
            PrintSongs(songs);

           
        }

        private static void PrintSongs(Song[] songs)
        {
            foreach(var song in songs)
            {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",song.Title,song.ArtistName,song.Length);
                




            }
        }
    }
}
