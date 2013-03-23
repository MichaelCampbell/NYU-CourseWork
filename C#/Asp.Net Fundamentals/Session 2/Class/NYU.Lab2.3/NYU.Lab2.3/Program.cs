using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NYU.Lab2._3
{
    class Program
    {
        #region
        static Random rand = new Random();
        static int numGames = 0, numBattles = 0, numWins = 0, numLosses = 0, numDraws = 0;
        enum BattleStatus
        {
            Lose = 0,
            Win = 1,
            Draw = 2
        }
        #endregion

        static void Main(string[] args)
        {
            string c = "";
            printHeader();
            for ( ; ; )
            {
                Console.Write("Command: ([P]lay, [S]core, [Q]uit): ");
                c = Console.ReadLine().ToLower();
                ProcessCommandLine(c);

            }
        }

        static void printHeader()
        {
        Console.WriteLine("************************************************************");
        Console.WriteLine("**                     Welcome to WAR                     **");
        Console.WriteLine("************************************************************");
        }

        static void ProcessCommandLine(string command)
        {
            if (command == "p" || command == "play")
            {
                //Play
                WageWar();
                //PrintScore(false);

            }
            else if (command == "s" || command == "score")
            {
                //Score
                PrintScore(false);

            }
            else if (command == "q" || command == "quit")
            {
                PrintScore(true);

            }
            else Console.WriteLine("**Invalid command**");
        }

        static void WageWar()
        {
            BattleStatus status = BattleStatus.Draw;
            numGames++;
            Console.WriteLine("\nGame# " + numGames);
            Console.WriteLine("========");
            while (status == BattleStatus.Draw)
            {
                status = DoBattle();
                if (status == BattleStatus.Draw)
                {
                    Console.WriteLine("Tie! TO WAR!");
                    //DoBattle();
                }
                else if (status == BattleStatus.Lose)
                {
                    Console.WriteLine("You LOSE!");
                }
                else if (status == BattleStatus.Win)
                {
                    Console.WriteLine("You WIN!");
                }
                else Console.WriteLine("Error");
            }
        }

        static void PrintScore(bool exitGame)
        {
            Console.WriteLine("\n********************************************************");
            Console.WriteLine("**                     Scoreboard                     **");
            Console.WriteLine("********************************************************");

            Console.WriteLine("Games:\t\t" + numGames);
            Console.WriteLine("Battles:\t" + numBattles);
            Console.WriteLine("Wins:\t\t" + numWins);
            Console.WriteLine("Losses:\t\t" + numLosses);
            Console.WriteLine("Draws:\t\t" + numDraws);

            if (exitGame == true)
            {
                Environment.Exit(0);
            }

        }

        static BattleStatus DoBattle()
        {
            int compScore = 0;
            int playerScore = 0;
            numBattles++;

            compScore = rand.Next(1, 15);
            playerScore = rand.Next(1, 15);

            Console.WriteLine("You draw a " + DisplayCard(playerScore));
            Console.WriteLine("Dealer draws a " + DisplayCard(compScore));

            if (compScore > playerScore)
            {
                numLosses++;
                return BattleStatus.Lose;
            }
            else if (compScore < playerScore)
            {
                numWins++;
                return BattleStatus.Win;
            }
            else
            {
                numDraws++;
                return BattleStatus.Draw;
            }
        }

        static string DisplayCard(int card)
        {
            if (card > 0 && card < 11)
            {
                return Convert.ToString(card);
            }
            else if (card == 11)
            {
                return "Jack";
            }
            else if (card == 12)
            {
                return "Queen";
            }
            else if (card == 13)
            {
                return "King";
            }
            else if (card == 14)
            {
                return "Ace";
            }
            else return "Invalid card";
        }
    }
}
