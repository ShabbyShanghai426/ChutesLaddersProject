using System.Diagnostics;

namespace ChutesAndLadders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int square;
            int roll;
            int turnCount;
            int turnSimulation;
            int turnSummary = 0;
            double turnAverage;
            int largestTurnCount = int.MinValue;
            int smallestTurnCount = int.MaxValue;

            turnSimulation = intTestInput("Enter Desired Amount of Games Played: ");

            for (int i = 0; i < turnSimulation; i++)
            {
                turnCount = 0;
                square = 0;
                while (square < 100)
                {

                    turnCount++;
                    roll = random.Next(1, 7);
                    if (square + roll <= 100)
                    {
                        square += roll;
                        square = CheckChutesAndLadders(square);
                    }
                }
                turnSummary += turnCount;

                if (largestTurnCount < turnCount)
                    largestTurnCount = turnCount;
                if (smallestTurnCount > turnCount)
                    smallestTurnCount = turnCount;

            }

            turnAverage = (double)turnSummary / turnSimulation;

            Console.WriteLine($"\nNumber of games played: {turnSimulation}");
            Console.WriteLine($"Average number of turns: {turnAverage}");
            Console.WriteLine($"Smallest amount of turns: {smallestTurnCount}");
            Console.WriteLine($"Largest amount of turns: {largestTurnCount}");

        }

        private static int intTestInput(string prompt)
        {
            string inputValue;
            int returnValue;

            do
            {
                Console.Write(prompt);
                inputValue = Console.ReadLine();


            } while (!int.TryParse(inputValue, out returnValue));

            return returnValue;
        }







        private static int CheckChutesAndLadders(int position)
        {
            // Ladders
            if (position == 1) return 38;
            if (position == 4) return 14;
            if (position == 9) return 31;
            if (position == 21) return 42;
            if (position == 28) return 84;
            if (position == 36) return 44;
            if (position == 51) return 67;
            if (position == 71) return 91;
            if (position == 80) return 100;

            // Chutes
            if (position == 16) return 6;
            if (position == 47) return 26;
            if (position == 49) return 11;
            if (position == 56) return 53;
            if (position == 62) return 19;
            if (position == 64) return 60;
            if (position == 87) return 24;
            if (position == 93) return 73;
            if (position == 95) return 75;
            if (position == 98) return 78;
            return position;
        }
    }
}