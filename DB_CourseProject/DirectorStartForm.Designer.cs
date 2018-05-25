namespace DB_CourseProject
{
    partial class DirectorStartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetItems = new System.Windows.Forms.Button();
            this.buttonGetReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetItems
            // 
            this.buttonGetItems.Location = new System.Drawing.Point(91, 103);
            this.buttonGetItems.Name = "buttonGetItems";
            this.buttonGetItems.Size = new System.Drawing.Size(247, 90);
            this.buttonGetItems.TabIndex = 0;
            this.buttonGetItems.Text = "Товары";
            this.buttonGetItems.UseVisualStyleBackColor = true;
            this.buttonGetItems.Click += new System.EventHandler(this.buttonGetItems_Click);
            // 
            // buttonGetReport
            // 
            this.buttonGetReport.Location = new System.Drawing.Point(88, 258);
            this.buttonGetReport.Name = "buttonGetReport";
            this.buttonGetReport.Size = new System.Drawing.Size(249, 89);
            this.buttonGetReport.TabIndex = 1;
            this.buttonGetReport.Text = "Отчётность";
            this.buttonGetReport.UseVisualStyleBackColor = true;
            // 
            // DirectorStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 455);
            this.Controls.Add(this.buttonGetReport);
            this.Controls.Add(this.buttonGetItems);
            this.Name = "DirectorStartForm";
            this.Text = "DirectorStartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetItems;
        private System.Windows.Forms.Button buttonGetReport;
    }
}