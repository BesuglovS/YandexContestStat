using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexContestStat.Data
{
    public class ContestOrder
    {
        public static Dictionary<int, int> order = new Dictionary<int, int>
        {
            {34493, 1},
            {31121, 2},
            {31122, 3},
            {31130, 4},
            {34859, 5},
            {31139, 6},
            {31941, 7},
            {32958, 8},
        };

        public static Dictionary<int, int> count = new Dictionary<int, int>
        {
            {34493, 10},
            {31121, 10},
            {31122, 10},
            {31130, 10},
            {34859, 10},
            {31139, 10},
            {31941, 13},
            {32958, 7},
        };
    }
}
