using System;
using System.Collections.Generic;
using System.Text;

namespace TictacToeSatiembre
{
    class Program
    {
        //fields
        static char P1;
        static char P2;
        static char inputch;
        static bool win = false;
        static char choice;
        static bool input = false;
        static int player = 2; //player 1 plays first
        static int i = 0;
        static int j = 0;
        static char ch;
        static char[,] pos = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };//boxes
        public static void UI()
        {
            Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t~0~     TICTACTOE      ~0~");
            Console.WriteLine("\t\t\t\t\t\t║by: Nicole P. Satiembre║");
            Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════╝");
            drawBoard();
            Console.ReadLine();
            Console.WriteLine("\t\t\t\tChoose background color. Press any key for default color.");
            Console.WriteLine("\t\t\t\t\t(1):DarkGray  (2):Red   (3): DarkGreen ");
            int bColor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\t\tChoose text color.Press any key for default color.");
            Console.WriteLine("\t\t\t\t\t(1): Yellow  (2):Cyan   (3): Magenta. ");
            int tColor = Convert.ToInt32(Console.ReadLine());

            switch (bColor)
            {
                case 1: Console.BackgroundColor = ConsoleColor.DarkGray; Console.Clear(); break;
                case 2: Console.BackgroundColor = ConsoleColor.DarkRed; Console.Clear(); break;
                case 3: Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Clear(); break;
                default: break;
            }
            switch (tColor)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case 2: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 3: Console.ForegroundColor = ConsoleColor.Magenta; break;
                default: break;
            }
        }
            public static void intro()
        {
            Console.WriteLine("\t\t\t\t\t\t╔═══════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t~0~     TICTACTOE      ~0~");
            Console.WriteLine("\t\t\t\t\t\t║by: Nicole P. Satiembre║");
            Console.WriteLine("\t\t\t\t\t\t╚═══════════════════════╝");
            Console.WriteLine("\t\t\t~0~RULES\n\n\t\t\t1.Choose your character. \n\t\t\t2.Choose the box you want to place. \n\t\t\t3.The first one who gets the winning pattern wins!");
        }

        /// <summary>
        /// The number of the box
        /// </summary>


        public static void drawBoard()
        {
            Console.WriteLine("\t\t\t\t\t\t  ╔═══╗   ╔═══╗   ╔═══╗   ");

            Console.WriteLine("\t\t\t\t\t\t  ║ {0} ║   ║ {1} ║   ║ {2} ║", pos[0, 0], pos[0, 1], pos[0, 2]);

            Console.WriteLine("\t\t\t\t\t\t  ╚═══╝   ╚═══╝   ╚═══╝");

            Console.WriteLine("\t\t\t\t\t\t  ╔═══╗   ╔═══╗   ╔═══╗   ");

            Console.WriteLine("\t\t\t\t\t\t  ║ {0} ║   ║ {1} ║   ║ {2} ║", pos[1, 0], pos[1, 1], pos[1, 2]);

            Console.WriteLine("\t\t\t\t\t\t  ╚═══╝   ╚═══╝   ╚═══╝");
            Console.WriteLine("\t\t\t\t\t\t  ╔═══╗   ╔═══╗   ╔═══╗   ");

            Console.WriteLine("\t\t\t\t\t\t  ║ {0} ║   ║ {1} ║   ║ {2} ║", pos[2, 0], pos[2, 1], pos[2, 2]);

            Console.WriteLine("\t\t\t\t\t\t  ╚═══╝   ╚═══╝   ╚═══╝");
            Console.WriteLine("\t\t\tEnter to continue.");
            Console.Read();


        }


        public static void NewGame()
        {
            pos[0, 0] = '1'; pos[0, 1] = '2'; pos[0, 2] = '3'; pos[1, 0] = '4'; pos[1, 1] = '5';
            pos[1, 2] = '6'; pos[2, 0] = '7'; pos[2, 1] = '8'; pos[2, 2] = '9';
            
            Console.Write("\n\t\t\tPlayer 1, please choose your character [X or O]: \n\t\t\t");
            inputch = Convert.ToChar(Console.ReadLine());
            //if wrong key
            while (!((inputch == 'O' || inputch == 'o') || (inputch == 'X' || inputch == 'x')))
            {
                Console.WriteLine("\t\t\tInvalid input. Please enter only (X) or (O):");
                inputch = Convert.ToChar(Console.ReadLine());
            }
            //sets player character
            if (inputch == 'X' || inputch == 'x') { P1 = 'X'; P2 = 'O'; }
            else { P1 = 'O'; P2 = 'X'; }
            Console.WriteLine("\n\t\t\tPlayer 1: {0}, Player 2: {1}", P1, P2);
        }
        public static void Horizontal()
        {
            if ((pos[0, 0] == pos[0, 1]) && (pos[0, 1] == pos[0, 2]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }
            else if ((pos[1, 0] == pos[1, 1]) && (pos[1, 1] == pos[1, 2]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }
            else if ((pos[2, 0] == pos[2, 1]) && (pos[2, 1] == pos[2, 2]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }

        }
        public static void Vertical()
        {
            if ((pos[0, 0] == pos[1, 0]) && (pos[1, 0] == pos[2, 0]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }

            else if ((pos[0, 1] == pos[1, 1]) && (pos[1, 1] == pos[2, 1]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }

            else if ((pos[0, 2] == pos[1, 2]) && (pos[1, 2] == pos[2, 2]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }

        }
        public static void Diagonal()
        {
            if ((pos[0, 0] == pos[1, 1]) && (pos[1, 1] == pos[2, 2]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }

            else if ((pos[0, 2] == pos[1, 1]) && (pos[1, 1] == pos[2, 0]))
            {
                Console.WriteLine("\t\t\t\t\t♣PLAYER {0} WINS!", player);
                win = true;
            }
        }


        static void Main(string[] args)
        {
            int turn = 0;
            UI();
            intro();
            NewGame();
            drawBoard();


            while (win == false) 
            {

                if ((turn == 9) && (win == false))
                {
                    
                    Console.Clear();
                    Console.WriteLine("\t\t\tIt's a TIE! Play again!");
                    win = false;
                    Console.Read();
                    NewGame();
                    drawBoard();
                    player = 2;
                }

                
                    if (player == 2)
                    {
                        player = 1;
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\t\t\tPlease choose your box, Player no. 1: \n\t\t\t");
                    
                    choice = Convert.ToChar(Console.ReadLine());
                        ch = P1;
                    


                    }
                    else
                    {
                        player = 2;
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\t\t\tPlease choose your box, Player no. 2: \n\t\t\t");
                   
                        choice = Convert.ToChar(Console.ReadLine());
                        ch = P2;
                    

                }
                
                



                do
                {

                    switch (choice)
                    {
                        case '1':
                            if (!(pos[0,0]=='X')|| (pos[0, 0] == 'O'))
                            {

                                pos[0, 0] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());
                                    
                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[0, 0] == ch);
                            }

                            break;
                        case '2':
                            if (!(pos[0, 1] == 'X') || (pos[0, 1] == 'O'))
                            {

                                pos[0, 1] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[0, 1] == ch);
                            }
                            break;
                        case '3':
                            if (!(pos[0, 2] == 'X') || (pos[0, 2] == 'O'))
                            {

                                pos[0, 2] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[0, 2] == ch);
                            }
                            break;
                        case '4':
                            if (!(pos[1, 0] == 'X') || (pos[1, 0] == 'O'))
                            {

                                pos[1, 0] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[1, 0] == ch);
                            }
                            break;
                        case '5':
                            if (!(pos[1, 1] == 'X') || (pos[1, 1] == 'O'))
                            {

                                pos[1, 1] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[1, 1] == ch);
                            }
                            break;
                        case '6':
                            if (!(pos[1, 2] == 'X') || (pos[1, 2] == 'O'))
                            {

                                pos[1, 2] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[1, 2] == ch);
                            }
                            break;
                        case '7':
                            if (!(pos[2, 0] == 'X') || (pos[2, 0] == 'O'))
                            {

                                pos[2, 0] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[2, 0] == ch);
                            }
                            break;
                        case '8':
                            if (!(pos[2, 1] == 'X') || (pos[2, 1] == 'O'))
                            {

                                pos[2, 1] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[2, 1] == ch);
                            }
                            break;
                        case '9':
                            if (!(pos[2, 2] == 'X') || (pos[2, 2] == 'O'))
                            {

                                pos[2, 2] = ch;
                                input = true; drawBoard();
                                Horizontal(); Vertical(); Diagonal();
                            }
                            else
                            {
                                do
                                {

                                    Console.WriteLine("\n\t\t\tPlace Occupied. Choose again: ");
                                    choice = Convert.ToChar(Console.ReadLine());

                                    input = false;
                                    i++;
                                    j++;
                                } while (pos[2, 2] == ch);
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong Character. Please enter only 1-9");
                            choice = Convert.ToChar(Console.ReadLine());
                            input = false;
                            break;

                    }
                    i++;
                    j++;
                } while (input == false);  //go batch to switch case



                turn++;
                i++;
                j++;


            }

            //win
            Console.WriteLine("\t\t\tPress any key to exit.");
            Console.ReadLine();

        }

    }
}

