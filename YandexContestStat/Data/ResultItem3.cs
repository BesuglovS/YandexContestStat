using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexContestStat.Data
{
    internal class ResultItem3
    {
        public string Student { get; set; }
        public List<string> results { get; set; }

        public ResultItem3(string student, List<string> results)
        {
            Student = student;
            this.results = results;
        }
    }
}
