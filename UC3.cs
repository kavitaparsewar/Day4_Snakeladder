using System;

namespace Day4_SnakeLadder
{
    class UC3
    {
         public static void check100()
            {
                int player = 0;
                //int noplay = 0;
                int snake = 2;
                int ladder = 1;
                int count = 0;
                int winning = 100;



                while (player <= winning)
                    do
                    {
                         Random random = new Random();
                        int optionCheck = random.Next(1, 4);
                        // if (optionCheck = 2 | 3)
                        //   ++count;
                        switch (optionCheck)
                        {
                            case 0:
                                Console.WriteLine("do not paly stay on same position");
                                break;
                            case 1:


                                Console.WriteLine("player move forward");
                                Random position = new Random();
                                ladder = position.Next(1, 7);
                                Console.WriteLine("ladder :  " + ladder);
                                player += ladder;
                                if (player > winning)
                                {
                                    player -= ladder;
                                    Console.WriteLine("abort playing because it go above 100");
                                }
                                break;


                            case 2:

                                Console.WriteLine("palyer move backword");
                                Random Position = new Random();
                                snake = Position.Next(1, 7);
                                // if (player <= 0)
                                //    player = 0;
                                //else
                                player -= snake;

                                Console.WriteLine("palyer move backword");
                                
                                snake = Position.Next(1, 7);

                                player -= snake;
                                if (player <= 0)
                                    player = 0;

                                break;

                        }


                        Console.WriteLine("dice is rolled  :" + count + "  times");
                        Console.WriteLine("player come in position : " + player);



                    } while (player <= winning);

            }
        }
    }


   
