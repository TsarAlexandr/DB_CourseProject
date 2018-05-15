namespace DB_CourseProject
{
    partial class StartForm
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
            this.buttonEmp = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmp
            // 
            this.buttonEmp.Location = new System.Drawing.Point(62, 57);
            this.buttonEmp.Name = "buttonEmp";
            this.buttonEmp.Size = new System.Drawing.Size(189, 75);
            this.buttonEmp.TabIndex = 0;
            this.buttonEmp.Text = "Сотрудники";
            this.buttonEmp.UseVisualStyleBackColor = true;
            this.buttonEmp.Click += new System.EventHandler(this.buttonEmp_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(62, 148);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(189, 75);
            this.buttonSales.TabIndex = 1;
            this.buttonSales.Text = "Журнал продаж";
            this.buttonSales.UseVisualStyleBackColor = true;
            // 
            // buttonPos
            // 
            this.buttonPos.Location = new System.Drawing.Point(234, 12);
            this.buttonPos.Name = "buttonPos";
            this.buttonPos.Size = new System.Drawing.Size(82, 29);
            this.buttonPos.TabIndex = 2;
            this.buttonPos.Text = "Должности";
            this.buttonPos.UseVisualStyleBackColor = true;
            this.buttonPos.Click += new System.EventHandler(this.buttonPos_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 309);
            this.Controls.Add(this.buttonPos);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonEmp);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmp;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonPos;
    }
}