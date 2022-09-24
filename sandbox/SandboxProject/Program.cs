//Tic-Tac-Toe
//Author: Kigame Kisia
using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> board = CreateBoard();
            string PlayLetter = "x";

            while (!EndGame(board))
            {
                DisplayBoard(board);

                int choice = Choice(PlayLetter);
                Move(board, choice, PlayLetter);

                PlayLetter = NextToPlay(PlayLetter);
            }

            DisplayBoard(board);
            Console.WriteLine("Thank you for playing. Goodbye!");
        }

        
        static List<string> CreateBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        static void DisplayBoard(List<string> board)
        {

            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

        static bool EndGame(List<string> board)
        {
            bool EndGame = false;

            if (Winner(board, "x") || Winner(board, "o"))
            {
                EndGame = true;
            }

            return EndGame;
        }

        static bool Winner(List<string> board, string player)
        {
            bool Winner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                Winner = true;
            }

            return Winner; 
        }

        
        static string NextToPlay(string currentPlayer)
        {
            string nextToPlay = "x";

            if (currentPlayer == "x")
            {
                nextToPlay = "o";
            }

            return nextToPlay;
        }

        
        static int Choice(string PlayerMark)
        {
            Console.Write($"{PlayerMark}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();

            int choice = int.Parse(move_string);
            return choice;
        }

        
        static void Move(List<string> board, int choice, string currentPlayer)
        {
            int index = choice - 1;

            board[index] = currentPlayer;
        }
    }
}