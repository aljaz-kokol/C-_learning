using System;

namespace C01_high_score
{
    class Program
    {
        private static int highscore = 300;
        private static string highscorePlayer = "Denis";
        
        static void Main(string[] args)
        {
            CheckHighscore(256, "Maria");
            CheckHighscore(315, "Michael");
            CheckHighscore(350, "Aljaz");
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New high-score is {score}");
                Console.WriteLine($"It is now held by {highscorePlayer}");
            } else
            {
                Console.WriteLine("The old high-score could not be broken.");
                Console.WriteLine($"It is still {highscore} and held by {highscorePlayer}");
            }
            Console.WriteLine();
        }
    }
}