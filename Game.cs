using System;
using System.Collections.Generic;

namespace How_Ridiculous
{
    public class Game
    {
        public List<List<int>> Frames=new List<List<int>>();
        public List<int> Strike=new List<int>();
        public List<int> Spare=new List<int>();

        int index=0;
        int subIndex=0;

        public Game(){
            for(int i=0; i<10; i++){
                this.Frames.Add(new List<int>() {-1, -1});
            }
            this.Frames[9].Add(-1);
        }

        public bool ThrowBall(int N){
            if(this.index<10){
                if(this.index<9){
                    if(subIndex<1 && N==10){ // Eto strayk
                        this.Strike.Add(this.index);
                        this.Frames[this.index][this.subIndex]=N;

                        this.index++;
                        this.subIndex=0;
                    } else {
                        this.Frames[this.index][this.subIndex]=N;

                        if(subIndex>0 && this.Frames[this.index][0]+this.Frames[this.index][1]==10){ // Eto sper
                            this.Spare.Add(this.index);
                        }
                        
                        this.subIndex++;
                        if(this.subIndex>1){
                            this.index++;
                            this.subIndex=0;
                        }
                    }
                } else {
                    if(N==10){ // Eto strayk
                        if(this.Strike.IndexOf(9)<0){
                            this.Strike.Add(this.index);
                        }
                        this.Frames[this.index][this.subIndex]=N;
                    } else {
                        this.Frames[this.index][this.subIndex]=N;
                    }

                    this.subIndex++;
                    if(this.subIndex>1){
                        if(this.Frames[this.index][0]+this.Frames[this.index][1]==10 && (this.Frames[this.index][0]!=0 || this.Frames[this.index][1]!=0) || this.Frames[this.index][1]==10){
                            this.subIndex=2;
                            if(this.Frames[this.index][0]+this.Frames[this.index][1]==10 && this.Spare.IndexOf(9)<0){
                                this.Spare.Add(this.index);
                            }
                        } else {
                            this.index++;
                            this.subIndex=0;
                        }
                    } 
                }
                return true;
            }
            return false;
        }

        public int Total(){
            return this.Сalculation(this.Frames.Count+1);
        }

        public int Сalculation(int I){
            int Sum=0;
            foreach (List<int> x in this.Frames.GetRange(0, I)){
                for(int y=0; y<2; y++){
                    if(x[y]>-1){
                        Sum+=x[y];
                    }
                }
            }
            foreach(int x in this.Strike){
                if(x<I){
                    if(x<9){
                        Sum+=this.Frames[x+1][0];
                        Sum+=(this.Frames[x+1][1]>-1)? this.Frames[x+1][1] : this.Frames[x+2][0];
                    } else {
                        Sum+=this.Frames[x][1]+this.Frames[x][2]-10;
                    }
                }
            }
            foreach(int x in this.Spare){
                if(x<I){
                    if(x<9){
                        Sum+=this.Frames[x+1][0];
                    } else if(this.Frames[x][0]+this.Frames[x][1]==10){
                        Sum+=this.Frames[x][2];
                    }
                }
            }

            return Sum;
        }

        public void Test(){
            Game partiya=new Game();

            Console.WriteLine("### Test_1 ############################################################################################################");
            for (int i=0; i<21; i++){
                if(partiya.ThrowBall(10)==false){ break; };
            } 
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 300\n\n\n");

            Console.WriteLine("### Test_2 ############################################################################################################");
            partiya=new Game();
            for (int i=0; i<21; i++){
                if(partiya.ThrowBall(5)==false){ break; };
            }
            partiya.PrintTable();
            Console.WriteLine(" Rezultat 150\n\n\n");

            Console.WriteLine("### Test_3 ############################################################################################################");
            partiya=new Game();

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

            partiya.PrintTable();
            Console.WriteLine(" Rezultat 82\n\n\n");

            Console.WriteLine("### Test_4 ############################################################################################################");
            partiya=new Game();

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

            partiya.PrintTable();
            Console.WriteLine(" Rezultat 131\n\n\n");

            Console.WriteLine("### Test_5 ############################################################################################################");
            partiya=new Game();

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

            partiya.PrintTable();
            Console.WriteLine(" Rezultat 193\n\n\n");

            Console.Read();
            Console.WriteLine("          █████████████████████████████████████████████████████████████████████████████████████████████████\n         ███████████████████████████████████████████▀▀▀░░░░░░░▀▀▀███████████████████████████████████████████\n        █████████████████████████████████████████▀░░░░░░░░░░░░░░░░░▀█████████████████████████████████████████\n       █████████████████████████████████████████│░░░░░░░░░░░░░░░░░░░│█████████████████████████████████████████\n      █████████████████████████████████████████▌│░░░░░░░░░░░░░░░░░░░│▐█████████████████████████████████████████\n     ██████████████████████████████████████████░└┐░░░░░░░░░░░░░░░░░┌┘░██████████████████████████████████████████\n    ███████████████████████████████████████████░░└┐░░░░░░░░░░░░░░░┌┘░░███████████████████████████████████████████\n   ████████████████████████████████████████████░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░████████████████████████████████████████████\n  █████████████████████████████████████████████▌░│██████▌░░░▐██████│░▐█████████████████████████████████████████████\n ███████████████████████████████████████████████░│▐███▀▀░░▄░░▀▀███▌│░███████████████████████████████████████████████\n  █████████████████████████████████████████████▀─┘░░░░░░░▐█▌░░░░░░░└─▀█████████████████████████████████████████████\n   ████████████████████████████████████████████▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄████████████████████████████████████████████\n    █████████████████████████████████████████████▄─┘██▌░░░░░░░▐██└─▄█████████████████████████████████████████████\n     █████████████████████████████████████████████░░▐█─┬┬┬┬┬┬┬─█▌░░█████████████████████████████████████████████\n      ███████████████████████████████████████████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐███████████████████████████████████████████\n       ███████████████████████████████████████████▄░░░└┴┴┴┴┴┴┴┘░░░▄███████████████████████████████████████████\n        ████████████████████████████████████████████▄░░░░░░░░░░░▄████████████████████████████████████████████\n         ██████████████████████████████████████████████▄▄▄▄▄▄▄██████████████████████████████████████████████\n          █████████████████████████████████████████████████████████████████████████████████████████████████\n\n\n");
        }

        public void PrintTable(){
            Console.Write("|   1  |   2  |   3  |   4  |   5  |   6  |   7  |   8  |   9  |   10   |\n| ");
            foreach (List<int> x in this.Frames){
                foreach (int y in x){
                    if(y<0){
                        Console.Write("  ");
                    } else if(y==10){
                        Console.Write("X ");
                    } else {
                        Console.Write(y.ToString()+" ");
                    }
                }
                Console.Write(" | ");
            }
            Console.Write("\n");
            for(int i=1; i<this.Frames.Count+1; i++){
                Console.Write("| {0,4} ", this.Сalculation(i));
            }
            Console.Write("  |\n");
        }
    }
}