using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp
{
    class GameEngine
    {
        public Fish CatchFish()
        {
            int r = GetRandomNumber();

            Fish fish = new Fish();


            if(r == 1)
            {
                fish.FishType = "Bass";
                fish.Points = 10;

            }
            else if(r == 2)
            {
                fish.FishType = "Perch";
                fish.Points = 2;
            }
            else if(r == 3)
            {
                fish.FishType = "Walleye";
                fish.Points = 20;
            }
            else if(r == 4)
            {
                fish.FishType = "Sunfish";
                fish.Points = 5;
            }
            else if(r == 5)
            {
                fish.FishType = "Pike";
                fish.Points = 30;
            }
            else
            {
                fish.FishType = "NO FISH!";
                fish.Points = 0;

            }






            return fish;
        }


        public int GetRandomNumber()
        {
            Random randomNum = new Random();
            int i = randomNum.Next(1, 8);
            return i;
        }


    }
}
