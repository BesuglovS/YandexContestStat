using Microsoft.VisualBasic.FileIO;
using YandexContestStat.Data;

namespace YandexContestStat
{
    public partial class MainForm : Form
    {
        List<ContestResult> results = new List<ContestResult>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {            
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                cssPath.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            if (File.Exists("startDir.txt"))
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string? line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    if ((line = sr.ReadLine()) != null)
                    {
                        cssPath.Text = line;
                    }
                }
            }

            results = new List<ContestResult>();

            string[] filePaths = Directory.GetFiles(cssPath.Text, "*.csv", System.IO.SearchOption.TopDirectoryOnly);

            foreach (string filePath in filePaths)
            {
                var contestNumber = int.Parse(filePath.Substring(filePath.LastIndexOf('-')+1, filePath.Length - 4 - (filePath.LastIndexOf('-') + 1)));
                using (TextFieldParser textFieldParser = new TextFieldParser(filePath))
                {
                    textFieldParser.TextFieldType = FieldType.Delimited;
                    textFieldParser.SetDelimiters(",");
                    while (!textFieldParser.EndOfData)
                    {
                        string[] rows = textFieldParser.ReadFields();
                        if (rows[0] != "place")
                        {
                            var name = "";
                            if (rows[1].Contains('('))
                                name = rows[1].Substring(0, rows[1].LastIndexOf('(') - 1);
                            else
                                name = rows[1];
                            var group = rows[2].Substring(0, rows[2].IndexOf('-'));
                            var score = int.Parse(rows[rows.Length - 2]);
                            var tasksCount = rows.Length - 5;

                            results.Add(new ContestResult(contestNumber, name, group, score, tasksCount));
                        }                        
                    }
                }
            }
            
            var groups = results.Select(item => item.StudentGroup).Distinct().OrderBy(i => i).ToList();
            groupComboBox.Items.Clear();
            groupComboBox.Items.AddRange(groups.ToArray<object>());
            if (groupComboBox.Items.Count > 0) groupComboBox.SelectedIndex = 0;
            groupComboBox2.Items.Clear();
            groupComboBox2.Items.AddRange(groups.ToArray<object>());
            if (groupComboBox2.Items.Count > 0) groupComboBox2.SelectedIndex = 0;

            var contests = results.Select(item => item.ContestNumber.ToString()).Distinct().OrderBy(i => i).ToList();
            contestComboBox.Items.Clear();
            contestComboBox.Items.AddRange(contests.ToArray<object>());
            if (contestComboBox.Items.Count > 0) contestComboBox.SelectedIndex = 0; 

            var students = results.Select(item => item.Student).Distinct().OrderBy(i => i).ToList();
            studentComboBox.Items.Clear();
            studentComboBox.Items.AddRange(students.ToArray<object>());
            if (studentComboBox.Items.Count > 0) studentComboBox.SelectedIndex = 0;
        }

        private void show_Click(object sender, EventArgs e)
        {
            var groupName = groupComboBox.SelectedItem as string;
            var contestNumber = int.Parse((string)contestComboBox.SelectedItem);

            var data = results
                .Where(item => (item.StudentGroup == groupName) && (item.ContestNumber == contestNumber))
                .OrderBy(item => item.Student)
                .ToList();

            var gridData = ResultItem.FromCSList(data);
            resultsGrid.DataSource = gridData;
            resultsGrid.Columns[0].HeaderText = "Ученик";
            resultsGrid.Columns[0].Width = 200;
            resultsGrid.Columns[1].HeaderText = "Задачи";
            resultsGrid.Columns[1].Width = 50;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            load.PerformClick();
        }

        private void showStudent_Click(object sender, EventArgs e)
        {
            var student = (string) (studentComboBox.SelectedItem);
            var data = results
                .Where(item => item.Student == student)                
                .ToList();

            var studentContests = data.Select(item => item.ContestNumber).ToList();

            foreach (var c in ContestOrder.order.Keys)
            {
                if (!studentContests.Contains(c))
                    data.Add(new ContestResult(c, student, "", 0, ContestOrder.count[c]));
            }

            data = data
                .OrderBy(item =>
                    ContestOrder.order.ContainsKey(item.ContestNumber) ?
                        ContestOrder.order[item.ContestNumber] :
                        1000)
                .ToList();

            var gridData = ResultItem2.FromCSList(data);
            resultsGrid.DataSource = gridData;
            resultsGrid.Columns[0].HeaderText = "Контест";
            resultsGrid.Columns[0].Width = 80;
            resultsGrid.Columns[1].HeaderText = "Задачи";
            resultsGrid.Columns[1].Width = 50;
        }

        private void show2_Click(object sender, EventArgs e)
        {
            var data = new List<ResultItem3>();

            var groupName = (string)groupComboBox2.SelectedItem;
            var names = results
                .Where(item => item.StudentGroup == groupName)
                .Select(item => item.Student)
                .OrderBy(item => item)
                .Distinct().ToList();
            var contests = results
                .Where(item => item.StudentGroup == groupName)
                .OrderBy(item =>
                    ContestOrder.order.ContainsKey(item.ContestNumber) ?
                        ContestOrder.order[item.ContestNumber] :
                        1000)
                .Select(item => item.ContestNumber)  
                .Distinct().ToList();

            foreach (var name in names)
            {
                var studentResults = new List<string>();

                foreach (var contest in contests)
                {
                    var r = results
                        .Where(item => (item.Student == name) && (item.ContestNumber == contest))
                        .FirstOrDefault();
                    if (r != null)
                    {
                        studentResults.Add(r.TasksCompleted + " / " + r.TasksCount);
                    } else
                    {
                        studentResults.Add("0 / " + ContestOrder.count[contest]);
                    }
                }

                data.Add(new ResultItem3(name, studentResults));
            }

            if (data.Count > 0) {
                resultsGrid.ColumnCount = 0;
                resultsGrid.Columns.Add("name", "Ученик");
                resultsGrid.Columns[0].Width = 150;
                foreach (var contest in contests)
                {
                    resultsGrid.Columns.Add("c" + contest.ToString(), contest.ToString());
                }

                var rowIndex = 0;
                foreach (var name in names)
                {
                    var studentItem = data.First(item => item.Student == name);
                    resultsGrid.Rows.Add();
                    resultsGrid.Rows[rowIndex].Cells[0].Value = name;

                    for (int i = 0; i < contests.Count; i++)                    
                    {
                        resultsGrid.Rows[rowIndex].Cells[i+1].Value = studentItem.results[i];

                        if (int.Parse(studentItem.results[i].Split('/')[0]) < 6)
                        {
                            resultsGrid.Rows[rowIndex].Cells[i + 1].Style.BackColor = Color.Pink;
                        }
                    }

                    rowIndex++;
                }
            }
        }
    }

}