namespace DB_CourseProject
{
    partial class Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonRemoveCurrent = new System.Windows.Forms.Button();
            this.buttonGetOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(27, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Кол-во";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(153, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказ";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddNew.Location = new System.Drawing.Point(33, 271);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(39, 38);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "+";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCurrent
            // 
            this.buttonRemoveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRemoveCurrent.Location = new System.Drawing.Point(131, 271);
            this.buttonRemoveCurrent.Name = "buttonRemoveCurrent";
            this.buttonRemoveCurrent.Size = new System.Drawing.Size(39, 38);
            this.buttonRemoveCurrent.TabIndex = 3;
            this.buttonRemoveCurrent.Text = "-";
            this.buttonRemoveCurrent.UseVisualStyleBackColor = true;
            // 
            // buttonGetOrder
            // 
            this.buttonGetOrder.Location = new System.Drawing.Point(331, 264);
            this.buttonGetOrder.Name = "buttonGetOrder";
            this.buttonGetOrder.Size = new System.Drawing.Size(156, 64);
            this.buttonGetOrder.TabIndex = 4;
            this.buttonGetOrder.Text = "Оформить заказ";
            this.buttonGetOrder.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 415);
            this.Controls.Add(this.buttonGetOrder);
            this.Controls.Add(this.buttonRemoveCurrent);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonRemoveCurrent;
        private System.Windows.Forms.Button buttonGetOrder;
    }
}