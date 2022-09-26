//Tic-Tac-Toe
//Author: Kigame Kisia
using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstBox = "1";
            string secondBox = "2";
            string thirdBox = "3";
            string fourthBox = "4";
            string fifthBox = "5";
            string sixthBox = "6";
            string seventhBox = "7";
            string eighthBox = "8";
            string ninethBox= "9";
            int win = 0;

            do {
                Console.WriteLine("Welcome to the Tic-Tac-Toe game");
                displayBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox);

                Console.Write ("x's turn to choose a square (1-9): ");
                string playerInput = Console.ReadLine();

                if (playerInput == "1") {
                    firstBox = "x";
                }
                else if (playerInput == "2") {
                    secondBox = "x";
                }
                else if (playerInput == "3") {
                    thirdBox = "x";
                }
                else if (playerInput == "4") {
                    fourthBox = "x";
                }
                else if (playerInput == "5") {
                    fifthBox = "x";
                }
                else if (playerInput == "6") {
                    sixthBox = "x";
                }
                else if (playerInput == "7") {
                    seventhBox= "x";
                }
                else if (playerInput == "8") {
                    eighthBox = "x";
                }
                else if (playerInput == "9") {
                    ninethBox = "x";
                }

                if (firstBox == "x" && fourthBox == "x" && seventhBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (firstBox == "x" && secondBox == "x" && thirdBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (firstBox == "x" && fifthBox == "x" && ninethBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    
                    break;
                }
                else if (secondBox == "x" && fifthBox == "x" && eighthBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (thirdBox == "x" && sixthBox == "x" && ninethBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (thirdBox == "x" && fifthBox == "x" && seventhBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (fourthBox == "x" && fifthBox == "x" && sixthBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (seventhBox == "x" && eighthBox == "x" && ninethBox == "x"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }

                displayBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox);

                Console.Write ("o's turn to choose a square (1-9): ");
                string player2Input = Console.ReadLine();

                if (player2Input == "1") {
                    firstBox = "o";
                }
                else if (player2Input == "2") {
                    secondBox = "o";
                }
                else if (player2Input == "3") {
                    thirdBox = "o";
                }
                else if (player2Input == "4") {
                    fourthBox = "o";
                }
                else if (player2Input == "5") {
                    fifthBox= "o";
                }
                else if (player2Input == "6") {
                    sixthBox = "o";
                }
                else if (player2Input == "7") {
                    seventhBox = "o";
                }
                else if (player2Input == "8") {
                    eighthBox = "o";
                }
                else if (player2Input == "9") {
                    ninethBox = "o";
                }

                if (firstBox == "o" && fifthBox == "o" && seventhBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (firstBox == "o" && secondBox == "o" && thirdBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (firstBox == "o" && fifthBox == "o" && ninethBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (secondBox == "o" && fifthBox == "o" && eighthBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (thirdBox == "o" && sixthBox == "o" && ninethBox == "o"){           
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (thirdBox == "o" && fifthBox == "o" && seventhBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (fourthBox == "o" && fifthBox== "o" && sixthBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
                else if (seventhBox == "o" && eighthBox == "o" && ninethBox == "o"){
                    winBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox, win);
                    break;
                }
            } while (win != 1);
        }

        static void displayBoard(string firstBox, string secondBox, string thirdBox, string fourthBox, string fifthBox, string sixthBox, string seventhBox, string eighthBox, string ninethBox){
            Console.WriteLine($"{firstBox}|{secondBox}|{thirdBox}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{fourthBox}|{fifthBox}|{sixthBox}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{seventhBox}|{eighthBox}|{ninethBox}");
            
        }
        static void winBoard(string firstBox, string secondBox, string thirdBox, string fourthBox, string fifthBox, string sixthBox, string seventhBox, string eighthBox, string ninethBox, int win){
            displayBoard(firstBox, secondBox, thirdBox, fourthBox, fifthBox, sixthBox, seventhBox, eighthBox, ninethBox);
            Console.WriteLine("Thank you for playing. Goodbye!");
            
        }
    
    }
}