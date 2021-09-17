using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_SnakeLadder
{
    class UC1_SinglePlayer
    {
        private static int prevPos;

        public static void singleplayer()
        {
            const int NO_PLAY = 0;
            const int SNAKE = 1;
            const int Ladder = 2;

            //variable
            int pos = 0;
            int prevpos, dicePlayed = 0;

            Console.WriteLine("snake and ladder program");
            Console.WriteLine("player is at start position");

            while (pos != 100)
            {
                while (pos < 100)
                {
                    Random random = new Random();
                    int die = random.Next(0, 6);

                    Console.WriteLine("Number the player give" + die);
                    //int die1 = (int)Math.Floor(Math.random() * 3);

                    int die1 = random.Next(0, 3) * 3;

                    prevpos = pos;

                    switch (die1)
                    {

                        case NO_PLAY:
                            Console.WriteLine("player doesnot play");
                            pos = pos;
                            dicePlayed++;
                            Console.WriteLine("player at position" + pos);
                            break;

                        case SNAKE:
                            Console.WriteLine("Player get the snake");
                            pos -= die;
                            dicePlayed++;

                            if (pos < 0)
                            {
                                pos = 0;
                                Console.WriteLine("player at position:" + pos);

                            }
                            else
                            {
                                Console.WriteLine("player at position:" + pos);

                            }
                            break;

                        case Ladder:
                            Console.WriteLine("Player get the ladder");
                            prevPos = pos;

                            pos += die;
                            dicePlayed++;

                            if (pos > 100)
                            {
                                pos = prevpos;
                                Console.WriteLine("Player at position:" + pos);
                            }
                            else
                            {
                                Console.WriteLine("Player at position:" + pos);
                            }
                            break;

                        default:

                            break;

                    }
                }


            }
            Console.WriteLine("Dice played to win the game" + dicePlayed);
        }
    }

}