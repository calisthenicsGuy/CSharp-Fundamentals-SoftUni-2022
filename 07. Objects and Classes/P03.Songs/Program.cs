using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Songs
{
    class Program
    {
        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }

            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());

                List<Song> songs = new List<Song>();
                for (int i = 1; i <= n; i++)
                {
                    string[] currentSong = Console.ReadLine()
                        .Split("_", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string typeList = currentSong[0];
                    string name = currentSong[1];
                    string time = currentSong[2];

                    Song newSong = new Song(typeList, name, time);

                    songs.Add(newSong);
                }

                string command = Console.ReadLine();

                if (command == "all")
                {
                    foreach (var item in songs)
                    {
                        Console.WriteLine(item.Name);
                    }
                }

                else
                {
                    List<Song> searchSonds = songs.FindAll(s => s.TypeList == command);
                    foreach (var item in searchSonds)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}