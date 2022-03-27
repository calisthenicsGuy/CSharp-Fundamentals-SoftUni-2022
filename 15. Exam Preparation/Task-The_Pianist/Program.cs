using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Task_The_Pianist
{
    class Piece
    {
        public Piece(string composer, string key)
        {
            this.Composer = composer;
            this.Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] pieceInformation = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string piece = pieceInformation[0];
                string composer = pieceInformation[1];
                string key = pieceInformation[2];

                pieces[piece] = new Piece(composer, key);
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];
                string piece = commandArgs[1];

                if (action == "Add")
                {
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces[piece] = new Piece(composer, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        continue;
                    }

                    pieces.Remove(piece);
                    Console.WriteLine($"Successfully removed {piece}!");
                }
                else if (action == "ChangeKey")
                {
                    string newKey = commandArgs[2];

                    if (!pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        continue;
                    }

                    pieces[piece].Key = newKey;
                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                }
            }

            foreach (KeyValuePair<string, Piece> piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }
}
