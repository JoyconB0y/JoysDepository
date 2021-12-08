using System;

namespace Sebastians_Leaderboads
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] players = new string[] 
            {
                "Joewho",
                "jonathan",
                "Joseph", "Frank",
                "Larry",
                "OPSlimy",
                "Vaz", "Ariza",
                "Sprooce",
                "Akky" 
            };
            string[] FinalNames = new string[10];
            int[] scores = new int[] 
            { 
              9999,
              8777, 
              8765, 
              7689, 
              7545, 
              7444, 
              6789, 
              6576, 
              6555, 
              6432
            };
            int[] FinalScores = new int[10];

            string input = "0";
            string Username = "0";
            int userScore = 0;
            int ScoreCheck = 0;
            while (input != "X" || input != "x")

            {
                Console.Clear();


                Console.WriteLine("Welcome to Sebastians Leaderboard");
                Console.WriteLine(" ");
                for (int i = 0; i < FinalScores.Length; i++)
                {
                    if (ScoreCheck < 10)
                    {
                        FinalScores[i] = scores[i];
                        FinalNames[i] = players[i];
                        ScoreCheck ++;
                    }
                    if (userScore >= FinalScores[i])
                    {
                        for(int I = i; I < FinalScores.Length; I++)
                        {

                        }
                        
                    }
                    Console.WriteLine("{0, -16} {1,4}", FinalNames[i], FinalScores[i]);

                }
                Console.WriteLine(" ");
                Console.WriteLine("Enter N for a new score or X to exit");
                input = Console.ReadLine();
                if (input == "N" || input == "n")
                {
                    Console.WriteLine("Username: ");
                    Username = Console.ReadLine();
                    Console.WriteLine("Score: ");
                    string scorestring = Console.ReadLine();
                    if (!int.TryParse(scorestring, out userScore))
                        while (userScore < 1)
                        {
                            Console.WriteLine("Score: ");
                            scorestring = Console.ReadLine();
                            if (!int.TryParse(scorestring, out userScore)) ;
                        }

                }
                if (input == "X" || input == "x")
                {
                    Console.WriteLine("Thanks for using Sebastians Leaderboard, have a nice day!");
                    return;
                }
            }
        }  
    }
}
