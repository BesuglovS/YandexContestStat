namespace YandexContestStat
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.browse = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.cssPath = new System.Windows.Forms.TextBox();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.ResultsViewPanel = new System.Windows.Forms.Panel();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.ResultsControlsPanel = new System.Windows.Forms.Panel();
            this.show2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupComboBox2 = new System.Windows.Forms.ComboBox();
            this.showStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contestComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.TopPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.ResultsViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.ResultsControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.browse);
            this.TopPanel.Controls.Add(this.load);
            this.TopPanel.Controls.Add(this.cssPath);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(839, 61);
            this.TopPanel.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(632, 14);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Обзор...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(713, 14);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 1;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // cssPath
            // 
            this.cssPath.Location = new System.Drawing.Point(20, 14);
            this.cssPath.Name = "cssPath";
            this.cssPath.Size = new System.Drawing.Size(606, 23);
            this.cssPath.TabIndex = 0;
            this.cssPath.Text = "e:\\Яндекс\\";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.ResultsViewPanel);
            this.ResultsPanel.Controls.Add(this.ResultsControlsPanel);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsPanel.Location = new System.Drawing.Point(0, 61);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(839, 564);
            this.ResultsPanel.TabIndex = 1;
            // 
            // ResultsViewPanel
            // 
            this.ResultsViewPanel.Controls.Add(this.resultsGrid);
            this.ResultsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsViewPanel.Location = new System.Drawing.Point(0, 106);
            this.ResultsViewPanel.Name = "ResultsViewPanel";
            this.ResultsViewPanel.Size = new System.Drawing.Size(839, 458);
            this.ResultsViewPanel.TabIndex = 1;
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(0, 0);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.RowTemplate.Height = 25;
            this.resultsGrid.Size = new System.Drawing.Size(839, 458);
            this.resultsGrid.TabIndex = 0;
            // 
            // ResultsControlsPanel
            // 
            this.ResultsControlsPanel.Controls.Add(this.show2);
            this.ResultsControlsPanel.Controls.Add(this.label3);
            this.ResultsControlsPanel.Controls.Add(this.groupComboBox2);
            this.ResultsControlsPanel.Controls.Add(this.showStudent);
            this.ResultsControlsPanel.Controls.Add(this.label2);
            this.ResultsControlsPanel.Controls.Add(this.studentComboBox);
            this.ResultsControlsPanel.Controls.Add(this.show);
            this.ResultsControlsPanel.Controls.Add(this.label1);
            this.ResultsControlsPanel.Controls.Add(this.contestComboBox);
            this.ResultsControlsPanel.Controls.Add(this.groupLabel);
            this.ResultsControlsPanel.Controls.Add(this.groupComboBox);
            this.ResultsControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultsControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultsControlsPanel.Name = "ResultsControlsPanel";
            this.ResultsControlsPanel.Size = new System.Drawing.Size(839, 106);
            this.ResultsControlsPanel.TabIndex = 0;
            // 
            // show2
            // 
            this.show2.Location = new System.Drawing.Point(200, 15);
            this.show2.Name = "show2";
            this.show2.Size = new System.Drawing.Size(112, 23);
            this.show2.TabIndex = 10;
            this.show2.Text = "Показать";
            this.show2.UseVisualStyleBackColor = true;
            this.show2.Click += new System.EventHandler(this.show2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Класс";
            // 
            // groupComboBox2
            // 
            this.groupComboBox2.FormattingEnabled = true;
            this.groupComboBox2.Location = new System.Drawing.Point(64, 16);
            this.groupComboBox2.Name = "groupComboBox2";
            this.groupComboBox2.Size = new System.Drawing.Size(121, 23);
            this.groupComboBox2.TabIndex = 8;
            // 
            // showStudent
            // 
            this.showStudent.Location = new System.Drawing.Point(713, 62);
            this.showStudent.Name = "showStudent";
            this.showStudent.Size = new System.Drawing.Size(112, 23);
            this.showStudent.TabIndex = 7;
            this.showStudent.Text = "Показать";
            this.showStudent.UseVisualStyleBackColor = true;
            this.showStudent.Click += new System.EventHandler(this.showStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ученик";
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(381, 62);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(311, 23);
            this.studentComboBox.TabIndex = 5;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(713, 19);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(112, 23);
            this.show.TabIndex = 4;
            this.show.Text = "Показать";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Контест";
            // 
            // contestComboBox
            // 
            this.contestComboBox.FormattingEnabled = true;
            this.contestComboBox.Location = new System.Drawing.Point(571, 20);
            this.contestComboBox.Name = "contestComboBox";
            this.contestComboBox.Size = new System.Drawing.Size(121, 23);
            this.contestComboBox.TabIndex = 2;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(337, 23);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(39, 15);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Класс";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(381, 20);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 23);
            this.groupComboBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 625);
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.Text = "Статистика Яндекс-контестов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResultsControlsPanel.ResumeLayout(false);
            this.ResultsControlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private Button browse;
        private Button load;
        private TextBox cssPath;
        private Panel ResultsPanel;
        private Panel ResultsViewPanel;
        private Panel ResultsControlsPanel;
        private Label groupLabel;
        private ComboBox groupComboBox;
        private Label label1;
        private ComboBox contestComboBox;
        private DataGridView resultsGrid;
        private Button show;
        private Label label2;
        private ComboBox studentComboBox;
        private Button showStudent;
        private Button show2;
        private Label label3;
        private ComboBox groupComboBox2;
    }
}