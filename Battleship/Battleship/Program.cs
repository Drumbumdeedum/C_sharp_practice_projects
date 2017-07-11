using System;
using System.Collections.Generic;

namespace Battleship
{
    internal class Program
    {       
        private static void Main(string[] args)
        {
            var totalShots = 0;
            var totalHits = 0;
            var totalMisses = 0;
            
            const int BOARD_SIZE = 20;                            
            var gameBoard = new int[BOARD_SIZE, BOARD_SIZE];
            var shipList = new List<Ship>();                    

            var shipToAdd = new Ship
            {
                Orientation = ShipOrientation.Horizontal,
                ShipSize = 5,
                Position_X = 2,
                Position_Y = 1
            };
            shipList.Add(shipToAdd);

            shipToAdd = new Ship
            {
                Orientation = ShipOrientation.Horizontal,
                ShipSize = 4,
                Position_X = 10,
                Position_Y = 2
            };
            shipList.Add(shipToAdd);

            shipToAdd = new Ship
            {
                Orientation = ShipOrientation.Vertical,
                ShipSize = 4,
                Position_X = 2,
                Position_Y = 13
            };
            shipList.Add(shipToAdd);
            
            shipToAdd = new Ship
            {
                Orientation = ShipOrientation.Vertical,
                ShipSize = 4,
                Position_X = 12,
                Position_Y = 16
            };
            shipList.Add(shipToAdd);
            
            shipToAdd = new Ship
            {
                Orientation = ShipOrientation.Horizontal,
                ShipSize = 4,
                Position_X = 12,
                Position_Y = 12
            };
            shipList.Add(shipToAdd);
            
            string userGuess = Console.ReadLine();           
            string guess_X_string = userGuess.Substring(0, 1);
            int guess_X = CoordConverter(guess_X_string);
            string guess_Y_string = userGuess.Substring(2);
            int guess_Y = int.Parse(guess_Y_string);
                        
            PrintBoard(gameBoard, totalShots, totalHits, totalMisses);       
        }
        
        public enum ShipOrientation
        {
            Horizontal,
            Vertical
        }
        
        public class Ship
        {
            public ShipOrientation Orientation { get; set; }
            public int ShipSize { get; set; } 
            public int Position_X { get; set; }
            public int Position_Y { get; set; }
            public int PositionX
            {
                set => Position_X --;
            }
            public int PositionY
            {
                set => Position_Y --;
            }
        }

        private static void PrintBoard(int[,] emtyBoard, int totalShots, int totalHits, int totalMisses)
        {
            Console.Clear();

            const int SPACES_BETWEEN_CHARS = 2;
            var intRowNumberMaxCharLength = (emtyBoard.GetUpperBound(0) + 1).ToString().Length;

            Console.Write(new string(' ', intRowNumberMaxCharLength + SPACES_BETWEEN_CHARS));

            var spacesBetweenColumnChars = new string(' ', SPACES_BETWEEN_CHARS);

            for (var intCol = 0; intCol <= emtyBoard.GetUpperBound(1); intCol++)
            {
                Console.Write((char) (65 + intCol) + spacesBetweenColumnChars);
            }
            Console.WriteLine();

            for (var intRow = 0; intRow <= emtyBoard.GetUpperBound(0); intRow++)
            {
                Console.Write(
                    new string(' ', intRowNumberMaxCharLength - (intRow + 1).ToString().Length)
                    +
                    (intRow + 1));

                Console.Write(spacesBetweenColumnChars);

                for (var intCol = emtyBoard.GetLowerBound(1); intCol <= emtyBoard.GetUpperBound(1); intCol++)
                {
                    Console.Write(".");
                    Console.Write(spacesBetweenColumnChars);
                }
                Console.WriteLine();                                
            }   
            Console.WriteLine("Total shots fired: " + totalShots);  
            Console.WriteLine("Total hits: " + totalHits);                
            Console.WriteLine("Total misses: " + totalMisses); 
        }

        public static int CoordConverter(string coordLetter)
        {
            var coord = 0;
            switch (coordLetter.ToUpper())
            {
                case "A":
                    coord = 1;
                    break;
                case "B":
                    coord = 2;
                    break;
                case "C":
                    coord = 3;
                    break;
                case "D":
                    coord = 4;
                    break;
                case "E":
                    coord = 5;
                    break;
                case "F":
                    coord = 6;
                    break;
                case "G":
                    coord = 7;
                    break;
                case "H":
                    coord = 8;
                    break;
                case "I":
                    coord = 9;
                    break;
                case "J":
                    coord = 10;
                    break;
                case "K":
                    coord = 11;
                    break;
                case "L":
                    coord = 12;
                    break;
                case "M":
                    coord = 13;
                    break;
                case "N":
                    coord = 14;
                    break;
                case "O":
                    coord = 15;
                    break;
                case "P":
                    coord = 16;
                    break;
                case "Q":
                    coord = 17;
                    break;
                case "R":
                    coord = 18;
                    break;
                case "S":
                    coord = 19;
                    break;
                case "T":
                    coord = 20;
                    break;
            }
            return coord;
        }
    }
}
        