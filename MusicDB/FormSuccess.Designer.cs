namespace Shop
{
    partial class FormSuccess
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
            this.generateReport = new System.Windows.Forms.Button();
            this.dateSuccess = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateReport
            // 
            this.generateReport.Location = new System.Drawing.Point(682, 158);
            this.generateReport.Margin = new System.Windows.Forms.Padding(2);
            this.generateReport.Name = "generateReport";
            this.generateReport.Size = new System.Drawing.Size(120, 41);
            this.generateReport.TabIndex = 18;
            this.generateReport.Text = "Сформировать отчет";
            this.generateReport.UseVisualStyleBackColor = true;
            this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
            // 
            // dateSuccess
            // 
            this.dateSuccess.FormattingEnabled = true;
            this.dateSuccess.Location = new System.Drawing.Point(682, 112);
            this.dateSuccess.Margin = new System.Windows.Forms.Padding(2);
            this.dateSuccess.Name = "dateSuccess";
            this.dateSuccess.Size = new System.Drawing.Size(120, 21);
            this.dateSuccess.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(648, 298);
            this.dataGridView1.TabIndex = 16;
            // 
            // selectDate
            // 
            this.selectDate.AutoSize = true;
            this.selectDate.Location = new System.Drawing.Point(700, 97);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(82, 13);
            this.selectDate.TabIndex = 19;
            this.selectDate.Text = "Выберите дату";
            // 
            // FormSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 336);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.generateReport);
            this.Controls.Add(this.dateSuccess);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSuccess";
            this.Text = "Исполненные заказы";
            this.Load += new System.EventHandler(this.FormSuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateReport;
        private System.Windows.Forms.ComboBox dateSuccess;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label selectDate;
    }
}