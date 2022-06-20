namespace Shop
{
    partial class FormMain
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
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
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.successReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canceledReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearch = new System.Windows.Forms.Label();
            this.generateReport = new System.Windows.Forms.Button();
            this.dateBefore = new System.Windows.Forms.DateTimePicker();
            this.dateAfter = new System.Windows.Forms.DateTimePicker();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.period = new System.Windows.Forms.Label();
            this.selectClient = new System.Windows.Forms.Label();
            this.checkStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(693, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(69, 32);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 20);
            this.search.TabIndex = 1;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.successReportsToolStripMenuItem,
            this.canceledReportsToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // successReportsToolStripMenuItem
            // 
            this.successReportsToolStripMenuItem.Name = "successReportsToolStripMenuItem";
            this.successReportsToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.successReportsToolStripMenuItem.Text = "Исполненные заказы";
            this.successReportsToolStripMenuItem.Click += new System.EventHandler(this.successReportsToolStripMenuItem_Click);
            // 
            // canceledReportsToolStripMenuItem
            // 
            this.canceledReportsToolStripMenuItem.Name = "canceledReportsToolStripMenuItem";
            this.canceledReportsToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.canceledReportsToolStripMenuItem.Text = "Отмененные заказы";
            this.canceledReportsToolStripMenuItem.Click += new System.EventHandler(this.canceledReportsToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.addToolStripMenuItem.Text = "Добавить запись";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // lyricsToolStripMenuItem
            // 
            this.lyricsToolStripMenuItem.Name = "lyricsToolStripMenuItem";
            this.lyricsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(9, 33);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Поиск";
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(602, 55);
            this.generateReport.Margin = new System.Windows.Forms.Padding(2);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(100, 38);
            this.generateReport.TabIndex = 10;
            this.generateReport.Text = "Сформировать отчет";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // dateBefore
            // 
            this.dateBefore.Location = new System.Drawing.Point(435, 47);
            this.dateBefore.Name = "dateBefore";
            this.dateBefore.Size = new System.Drawing.Size(137, 20);
            this.dateBefore.TabIndex = 17;
            // 
            // dateAfter
            // 
            this.dateAfter.Location = new System.Drawing.Point(435, 73);
            this.dateAfter.Name = "dateAfter";
            this.dateAfter.Size = new System.Drawing.Size(137, 20);
            this.dateAfter.TabIndex = 18;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(269, 50);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 21);
            this.cbClient.TabIndex = 19;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(483, 31);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(45, 13);
            this.period.TabIndex = 20;
            this.period.Text = "Период";
            // 
            // selectClient
            // 
            this.selectClient.AutoSize = true;
            this.selectClient.Location = new System.Drawing.Point(280, 34);
            this.selectClient.Name = "selectClient";
            this.selectClient.Size = new System.Drawing.Size(101, 13);
            this.selectClient.TabIndex = 21;
            this.selectClient.Text = "Выберите клиента";
            // 
            // checkStatus
            // 
            this.checkStatus.Location = new System.Drawing.Point(78, 66);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(147, 39);
            this.checkStatus.TabIndex = 22;
            this.checkStatus.Text = "Проверить статус";
            this.checkStatus.UseVisualStyleBackColor = true;
            this.checkStatus.Click += new System.EventHandler(this.checkStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "До:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.selectClient);
            this.Controls.Add(this.period);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.dateAfter);
            this.Controls.Add(this.dateBefore);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "OrdersApp";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem successReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canceledReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lyricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.DateTimePicker dateBefore;
        private System.Windows.Forms.DateTimePicker dateAfter;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label selectClient;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button checkStatus;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}