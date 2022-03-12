using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexContestStat.Data
{
    public  class ResultItem2
    {
        public string ContestNumber { get; set; }
        public string Score { get; set; }

        public ResultItem2(string cn, string score)
        {
            ContestNumber = cn;
            Score = score;
        }

        public static ResultItem2 FromCS(ContestResult item)
        {
            return new ResultItem2(item.ContestNumber.ToString(), item.TasksCompleted + " / " + item.TasksCount);
        }

        public static List<ResultItem2> FromCSList(List<ContestResult> list)
        {
            return list.Select(item => FromCS(item)).ToList();
        }
    }
}
