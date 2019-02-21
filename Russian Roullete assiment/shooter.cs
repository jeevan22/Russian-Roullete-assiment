using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete_assiment
{
    class shooter
    {
        //all the variable defined here
        public int loader;
        public int spiner;

        public int playagain;
        
        
        public int shoted=0;
        public int point(int points)
        {
            if (playagain == 0)
            {
                points = 1;
            }


            do
            {
                if (shoted == 0 && loader == spiner)//if statement
                {

                    points = 100;//sets the point to 100
                    shoted = 3;//sets the value of shoted=3
                    playagain = 0;
                }
                else if (shoted == 1 && loader == spiner)
                {
                    points = 50;//sets the point to 50
                    shoted = 3;//sets the value of shoted=3
                    playagain = 0;//this varable sets the value of playagain=0

                }
                else if (shoted == 2)
                {
                    points = 0;
                    shoted = 3;
                    playagain = playagain - 1;

                }
                else
                {
                    shoted++;//increset the value of shoted by 1
                    spiner = spined(spiner);
                }
            }
            while (shoted <= 2);//do while loop will runs until value of shoted is <=2

            return points;

        }
        public int spined(int spin)//spin method
        {
            if (spin == 6)
            {
                spin = 1;
            }
            else
            {
                spin++;
            }
            return spin;
        }
    }
}
