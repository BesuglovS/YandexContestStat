using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexContestStat.Data
{
    public class ResultItem
    {
        public string name { get; set; }
        public int score { get; set; }

        public ResultItem(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public static ResultItem FromCS(ContestResult item)
        {
            return new ResultItem(item.Student, item.TasksCompleted);
        }

        public static List<ResultItem> FromCSList(List<ContestResult> list)
        {
            return list.Select(item => FromCS(item)).ToList();
        }
    }
}
