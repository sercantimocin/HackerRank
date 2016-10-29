using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }
            res = Lonelyinteger(_a);
            Console.WriteLine(res);
        }

        static int Lonelyinteger(int[] a)
        {

            int result = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                result = result ^ a[i];
            }

            return result;
        }
    }
}
