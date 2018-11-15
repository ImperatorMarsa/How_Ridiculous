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
                    } else if(subIndex>0 && this.Frames[this.index][0]+this.Frames[this.index][1]==10){ // Eto sper
                        this.Spare.Add(this.index);
                        this.Frames[this.index][this.subIndex]=N;

                        this.index++;
                        this.subIndex=0;
                    } else {
                        this.Frames[this.index][this.subIndex]=N;

                        this.subIndex++;
                        if(this.subIndex>1){
                            this.index++;
                            this.subIndex=0;
                        }
                    }
                } else {
                    if(N==10){ // Eto strayk
                        this.Strike.Add(this.index);
                        this.Frames[this.index][this.subIndex]=N;
                    } else {
                        this.Frames[this.index][this.subIndex]=N;
                    }

                    this.subIndex++;
                    if(this.subIndex>1){
                        if(this.Frames[this.index][0]+this.Frames[this.index][1]==10){
                            this.subIndex=2;
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

        public void PrintTable(){
            Console.Write("|   1  |   2  |   3  |   4  |   5  |   6  |   7  |   8  |   9  |   10   |\n| ");
            foreach (List<int> x in this.Frames)
            {
                foreach (int y in x)
                {
                    if(y<0){
                        Console.Write(" ");
                    } else {
                        Console.Write(y.ToString()+" ");
                    }
                }
                Console.Write(" | ");
            }
            Console.Write("\n\n");
        }
    }
}