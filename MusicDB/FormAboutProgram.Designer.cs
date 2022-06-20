namespace Shop
{
    partial class FormAboutPogram
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
            this.infoProgram = new System.Windows.Forms.Label();
            this.aboutMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoProgram
            // 
            this.infoProgram.AutoSize = true;
            this.infoProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoProgram.ForeColor = System.Drawing.Color.Maroon;
            this.infoProgram.Location = new System.Drawing.Point(57, 171);
            this.infoProgram.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoProgram.Name = "infoProgram";
            this.infoProgram.Size = new System.Drawing.Size(405, 34);
            this.infoProgram.TabIndex = 0;
            this.infoProgram.Text = "C# форма для отслеживания статуса заказов \r\n генерации отчётов в MS Excel и поиск" +
    "а по товарам.\r\n";
            this.infoProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutMe
            // 
            this.aboutMe.AutoSize = true;
            this.aboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboutMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.aboutMe.Location = new System.Drawing.Point(140, 96);
            this.aboutMe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(247, 36);
            this.aboutMe.TabIndex = 1;
            this.aboutMe.Text = "Худышкин Евгений Денисович\n34 группа, 2022 год\n";
            this.aboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAboutPogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 344);
            this.Controls.Add(this.aboutMe);
            this.Controls.Add(this.infoProgram);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAboutPogram";
            this.Text = "О разработчике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoProgram;
        private System.Windows.Forms.Label aboutMe;
    }
}