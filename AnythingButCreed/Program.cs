using AnythingButCreed.Songs;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodList = new List<Song>();

            var allSongs = new List<Song>() 
            { 
                new Song("Creed", "One Last Breath"),
                new Song("Led Zeppelin", "When the Levee Breaks"),
                new Song("NSYNC", "Bye Bye Bye"),
                new Song("Rage Against the Machine", "Killing in the Name Of"),
                new Song("Hall and Oates", "Private Eyes"),
                new Song("Led Zeppelin", "Kashmir"),
                new Song("Rage Against the Machine", "Rodeo"),
                new Song("Creed", "Higher"),
                new Song("Hall and Oates", "Rich Girl")
            };

            Console.WriteLine("All Songs: \r\n");

            foreach (var song in allSongs)
            {
                Console.WriteLine($"{song.Name} by {song.Artist}");
            }

            Console.WriteLine("\r\nLet's try to make a better playlist.\r\n");

            foreach (var song in allSongs)
            {
                if (song.Artist.Contains("Creed"))
                {
                    Console.WriteLine($"Ew No I hate {song.Name}");
                }
                else
                {
                    Console.WriteLine($"{song.Artist} is okay");
                    goodList.Add(song);
                }
            }

            Console.WriteLine("\r\nGOOD SONGS: \r\n");

            foreach (var song in goodList)
            {
                Console.WriteLine($"{song.Name} by {song.Artist}");
            }

        }
    }
}
