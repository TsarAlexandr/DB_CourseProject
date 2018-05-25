namespace DB_CourseProject
{
    partial class SalesManagerStartForm
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
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonMySales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(61, 65);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(240, 95);
            this.buttonNewOrder.TabIndex = 0;
            this.buttonNewOrder.Text = "Оформить новый заказ";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonMySales
            // 
            this.buttonMySales.Location = new System.Drawing.Point(61, 203);
            this.buttonMySales.Name = "buttonMySales";
            this.buttonMySales.Size = new System.Drawing.Size(240, 95);
            this.buttonMySales.TabIndex = 1;
            this.buttonMySales.Text = "Мои заказы";
            this.buttonMySales.UseVisualStyleBackColor = true;
            this.buttonMySales.Click += new System.EventHandler(this.buttonMySales_Click);
            // 
            // SalesManagerStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 332);
            this.Controls.Add(this.buttonMySales);
            this.Controls.Add(this.buttonNewOrder);
            this.Name = "SalesManagerStartForm";
            this.Text = "SalesManagerStartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Button buttonMySales;
    }
}