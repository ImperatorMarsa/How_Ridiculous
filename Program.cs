using System;
using System.Collections.Generic;

namespace How_Ridiculous
{
    class Program
    {
        static void Main(string[] args)
        {
            Game partiya=new Game();

            Console.WriteLine("### Test_1 ############################################################################################################");
            for (int i=0; i<21; i++)
            {
                if(partiya.ThrowBall(10)==false){ break; };
            } 
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 300\n\n\n");

            Console.WriteLine("### Test_2 ############################################################################################################");
            partiya=new Game();
            for (int i=0; i<21; i++)
            {
                if(partiya.ThrowBall(5)==false){ break; };
            }
            partiya.PrintTable();

            Console.WriteLine("### Test_3 ############################################################################################################");
            partiya=new Game();
            {
                partiya.ThrowBall(9);
                partiya.ThrowBall(0);

                partiya.ThrowBall(3);
                partiya.ThrowBall(5);

                partiya.ThrowBall(6);
                partiya.ThrowBall(1);

                partiya.ThrowBall(3);
                partiya.ThrowBall(6);

                partiya.ThrowBall(8);
                partiya.ThrowBall(1);

                partiya.ThrowBall(5);
                partiya.ThrowBall(3);

                partiya.ThrowBall(2);
                partiya.ThrowBall(5);

                partiya.ThrowBall(8);
                partiya.ThrowBall(0);

                partiya.ThrowBall(7);
                partiya.ThrowBall(1);

                partiya.ThrowBall(8);
                partiya.ThrowBall(1);
                partiya.ThrowBall(0);
            } 
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 82\n\n\n");

            Console.WriteLine("### Test_4 ############################################################################################################");
            partiya=new Game();
            {
                partiya.ThrowBall(9);
                partiya.ThrowBall(0);

                partiya.ThrowBall(3);
                partiya.ThrowBall(7);

                partiya.ThrowBall(6);
                partiya.ThrowBall(1);

                partiya.ThrowBall(3);
                partiya.ThrowBall(7);

                partiya.ThrowBall(8);
                partiya.ThrowBall(1);

                partiya.ThrowBall(5);
                partiya.ThrowBall(5);

                partiya.ThrowBall(0);
                partiya.ThrowBall(10);

                partiya.ThrowBall(8);
                partiya.ThrowBall(0);

                partiya.ThrowBall(7);
                partiya.ThrowBall(3);

                partiya.ThrowBall(8);
                partiya.ThrowBall(2);
                partiya.ThrowBall(8);
            } 
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 131\n\n\n");

            Console.WriteLine("### Test_5 ############################################################################################################");
            partiya=new Game();
            {
                partiya.ThrowBall(10);

                partiya.ThrowBall(3);
                partiya.ThrowBall(7);

                partiya.ThrowBall(6);
                partiya.ThrowBall(1);

                partiya.ThrowBall(10);

                partiya.ThrowBall(10);

                partiya.ThrowBall(10);

                partiya.ThrowBall(2);
                partiya.ThrowBall(8);

                partiya.ThrowBall(9);
                partiya.ThrowBall(0);

                partiya.ThrowBall(7);
                partiya.ThrowBall(3);

                partiya.ThrowBall(10);
                partiya.ThrowBall(10);
                partiya.ThrowBall(10);
            } 
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 193\n\n\n");

            Console.Read();
            Console.WriteLine("          █████████████████████████████████████████████████████████████████████████████████████████████████\n         ███████████████████████████████████████████▀▀▀░░░░░░░▀▀▀███████████████████████████████████████████\n        █████████████████████████████████████████▀░░░░░░░░░░░░░░░░░▀█████████████████████████████████████████\n       █████████████████████████████████████████│░░░░░░░░░░░░░░░░░░░│█████████████████████████████████████████\n      █████████████████████████████████████████▌│░░░░░░░░░░░░░░░░░░░│▐█████████████████████████████████████████\n     ██████████████████████████████████████████░└┐░░░░░░░░░░░░░░░░░┌┘░██████████████████████████████████████████\n    ███████████████████████████████████████████░░└┐░░░░░░░░░░░░░░░┌┘░░███████████████████████████████████████████\n   ████████████████████████████████████████████░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░████████████████████████████████████████████\n  █████████████████████████████████████████████▌░│██████▌░░░▐██████│░▐█████████████████████████████████████████████\n ███████████████████████████████████████████████░│▐███▀▀░░▄░░▀▀███▌│░███████████████████████████████████████████████\n  █████████████████████████████████████████████▀─┘░░░░░░░▐█▌░░░░░░░└─▀█████████████████████████████████████████████\n   ████████████████████████████████████████████▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄████████████████████████████████████████████\n    █████████████████████████████████████████████▄─┘██▌░░░░░░░▐██└─▄█████████████████████████████████████████████\n     █████████████████████████████████████████████░░▐█─┬┬┬┬┬┬┬─█▌░░█████████████████████████████████████████████\n      ███████████████████████████████████████████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐███████████████████████████████████████████\n       ███████████████████████████████████████████▄░░░└┴┴┴┴┴┴┴┘░░░▄███████████████████████████████████████████\n        ████████████████████████████████████████████▄░░░░░░░░░░░▄████████████████████████████████████████████\n         ██████████████████████████████████████████████▄▄▄▄▄▄▄██████████████████████████████████████████████\n          █████████████████████████████████████████████████████████████████████████████████████████████████\n\n\n");
        }
    }
}