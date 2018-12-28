using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            List<int> moveList = new List<int>();

            do
            {
                int newMove = Convert.ToInt32(Console.ReadLine());
                moveList.Add(newMove);
                count--;
            } while (count > 0);

            foreach (var move in moveList)
            {
                Console.WriteLine(move%7 > 1 ? "First" : "Second");
            }

            Console.ReadKey();
        }

        static bool PlayGame(int stoneCount, bool turn)
        {

            if (stoneCount <= 1)
            {
                return !turn;
            }
            else if (stoneCount == 2 && stoneCount == 3 && stoneCount == 5)
            {
                return turn;
            }
            else
            {
                turn = !turn;
                bool? result1 = null, result2 = null, result3 = null;

                int tryFive = stoneCount - 5;
                if (tryFive > 0)
                {
                    result3 = PlayGame(tryFive, turn);
                }

                int tryThree = stoneCount - 3;
                if (tryThree > 0)
                {
                    result2 = PlayGame(tryThree, turn);
                }

                int tryTwo = stoneCount - 2;
                if (tryTwo > 0)
                {
                    result1 = PlayGame(tryTwo, turn);
                }

                bool finalResult = result1.GetValueOrDefault();

                if (result2.HasValue)
                {
                    finalResult = finalResult || result2.Value;
                }

                if (result3.HasValue)
                {
                    finalResult = finalResult || result3.Value;
                }

                return finalResult;
            }
        }
    }
}
