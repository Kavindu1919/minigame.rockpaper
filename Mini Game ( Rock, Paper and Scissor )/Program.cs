using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Game___Rock__Paper_and_Scissor__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string player, computer;
            int randomInt;

            bool playAgain=true;
            while (playAgain)
            {
                int cpuwins = 0;
                int playerwins = 0;

                while (playerwins < 3 && cpuwins < 3)
                {

                    Console.Write("Enter Between ROCK , PAPER and SCISSOR :   ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1,4);


                    switch (randomInt)
                        {
                        case 1:
                            computer = "ROCK";
                            Console.WriteLine("COMPUTER CHOOSE ROCK");

                            if (player == "ROCK")
                            {
                                Console.WriteLine("DRAW !!\n");
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("YOU WIN\n");
                                playerwins++;
                            }
                            else if (player == "SCISSOR")
                            {
                                Console.WriteLine("COMPUTER WIN\n");
                                cpuwins++;
                            }
                            break;
                        case 2:
                            computer = "PAPER";
                            Console.WriteLine("COMPUTER CHOOSE PAPER");
                            if (player == "PAPER")
                            {
                                Console.WriteLine("DRAW !!\n");
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WIN\n");
                                cpuwins++;
                            }
                            else if (player == "SCISSOR")
                            {
                                Console.WriteLine("YOU WIN \n");
                                playerwins++;
                            }
                            break;
                        case 3:
                            computer = "SCISSOR";
                            Console.WriteLine("COMPUTER CHOOSE SCISSOR");
                            if (player == "SCISSOR")
                            {
                                Console.WriteLine("DRAW !!\n");
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WIN\n");
                                cpuwins++;
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("YOU WIN \n");
                                playerwins++;
                            }
                            break;
                        default:
                            Console.WriteLine("INVALID ENTRY!!!\n");
                            break;
                        }

                    Console.WriteLine("\n PLAYER SCORE:{0}\tCOMPUTER SCORE:{1}",playerwins,cpuwins);

                    if (playerwins == 3)
                    {
                        Console.WriteLine("YOU'R THE CHAMPION!\n\n");
                    }
                    else if (cpuwins == 3)
                    {
                        Console.WriteLine("COMPUTER IS THE CHAMPION!!!\n\n");
                    } 
                    else
                    {

                    }

                    

                }
                Console.Write("DO YOU WANNA PLAY AGAING ? (y/n) ");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }

        }
    }
}