using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Print welcome message and ask for Username

            //printing Welcome message
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("WELCOME TO THE FISHING GAME");
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine("BY BRANDON");
            //ask user what their Username is
            Console.WriteLine("What is your Username?");


            //making a variable and capturing the data from the user
            string userInput = Console.ReadLine();

            //Print out the username
            Console.WriteLine("Hello:" + userInput);


            #endregion

            #region Create Player object and set score to 0
            //created a new instance of Player and set the Username
            Player player1 = new Player();
            player1.Username = userInput;
            player1.Score = 0;



            Console.WriteLine("player1 Username:" + player1.Username);
            Console.WriteLine("player1 Score:" + player1.Score);
            #endregion


            GameEngine game = new GameEngine();
            Fish fish1 = game.CatchFish();

            Console.WriteLine("fish1 FishType:" + fish1.FishType);
            Console.WriteLine("fish1 Score:" + fish1.Points);

            player1.Score = player1.Score + fish1.Points;

            Console.WriteLine("player1 Score:" + player1.Score);





            Fish fish2 = game.CatchFish();

            Console.WriteLine("fish2 FishType:" + fish2.FishType);
            Console.WriteLine("fish2 Score:" + fish2.Points);

            player1.Score = player1.Score + fish2.Points;

            Console.WriteLine("player1 Score:" + player1.Score);


        }
    }
}
