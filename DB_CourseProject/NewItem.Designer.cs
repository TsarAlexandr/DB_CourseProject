namespace DB_CourseProject
{
    partial class NewItem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tDeviceIdLabel;
            System.Windows.Forms.Label typeIdLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.devicesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.DevicesTableAdapter();
            this.typesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TypesTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.buttonAddType = new System.Windows.Forms.Button();
            this.buttonAddDevice = new System.Windows.Forms.Button();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevios = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            tDeviceIdLabel = new System.Windows.Forms.Label();
            typeIdLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tDeviceIdLabel
            // 
            tDeviceIdLabel.AutoSize = true;
            tDeviceIdLabel.Location = new System.Drawing.Point(15, 27);
            tDeviceIdLabel.Name = "tDeviceIdLabel";
            tDeviceIdLabel.Size = new System.Drawing.Size(111, 13);
            tDeviceIdLabel.TabIndex = 3;
            tDeviceIdLabel.Text = "Целевое устройство";
            // 
            // typeIdLabel
            // 
            typeIdLabel.AutoSize = true;
            typeIdLabel.Location = new System.Drawing.Point(272, 27);
            typeIdLabel.Name = "typeIdLabel";
            typeIdLabel.Size = new System.Drawing.Size(26, 13);
            typeIdLabel.TabIndex = 5;
            typeIdLabel.Text = "Тип";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(75, 99);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(83, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Наименование";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(75, 122);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(67, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Цена за шт.";
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = this.devicesTableAdapter;
            this.tableAdapterManager.Employees1TableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.TypesTableAdapter = this.typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(164, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(164, 122);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 10;
            // 
            // buttonAddType
            // 
            this.buttonAddType.Location = new System.Drawing.Point(384, 51);
            this.buttonAddType.Name = "buttonAddType";
            this.buttonAddType.Size = new System.Drawing.Size(25, 21);
            this.buttonAddType.TabIndex = 11;
            this.buttonAddType.Text = "+";
            this.buttonAddType.UseVisualStyleBackColor = true;
            this.buttonAddType.Click += new System.EventHandler(this.buttonAddType_Click);
            // 
            // buttonAddDevice
            // 
            this.buttonAddDevice.Location = new System.Drawing.Point(164, 52);
            this.buttonAddDevice.Name = "buttonAddDevice";
            this.buttonAddDevice.Size = new System.Drawing.Size(25, 21);
            this.buttonAddDevice.TabIndex = 12;
            this.buttonAddDevice.Text = "+";
            this.buttonAddDevice.UseVisualStyleBackColor = true;
            this.buttonAddDevice.Click += new System.EventHandler(this.buttonAddDevice_Click);
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "Types";
            this.typesBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(210, 208);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 64);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "--->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // buttonPrevios
            // 
            this.buttonPrevios.Location = new System.Drawing.Point(129, 208);
            this.buttonPrevios.Name = "buttonPrevios";
            this.buttonPrevios.Size = new System.Drawing.Size(75, 64);
            this.buttonPrevios.TabIndex = 14;
            this.buttonPrevios.Text = "<----";
            this.buttonPrevios.UseVisualStyleBackColor = true;
            this.buttonPrevios.Click += new System.EventHandler(this.buttonPrevios_Click_1);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(303, 208);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 15;
            this.buttonLast.Text = "Последняя";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click_1);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(23, 208);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 16;
            this.buttonFirst.Text = "Первая";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(455, 125);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(65, 30);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Новый";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(428, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 61);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(164, 168);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsBindingSource, "tDeviceId", true));
            this.comboBox1.DataSource = this.devicesBindingSource;
            this.comboBox1.DisplayMember = "devName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "devId";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsBindingSource, "typeId", true));
            this.comboBox2.DataSource = this.typesBindingSource;
            this.comboBox2.DisplayMember = "type";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(242, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "typeId";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 284);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevios);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonAddDevice);
            this.Controls.Add(this.buttonAddType);
            this.Controls.Add(tDeviceIdLabel);
            this.Controls.Add(typeIdLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Name = "NewItem";
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private ComputerFirmDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button buttonAddType;
        private System.Windows.Forms.Button buttonAddDevice;
        private ComputerFirmDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private ComputerFirmDataSetTableAdapters.TypesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevios;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}