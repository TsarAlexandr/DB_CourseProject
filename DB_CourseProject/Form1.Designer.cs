namespace DB_CourseProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label posIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrevios = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.computerFirmDataSet = new DB_CourseProject.ComputerFirmDataSet();
            this.employees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees1TableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.Employees1TableAdapter();
            this.tableAdapterManager = new DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager();
            this.positionsTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.PositionsTableAdapter();
            this.salesTableAdapter = new DB_CourseProject.ComputerFirmDataSetTableAdapters.SalesTableAdapter();
            this.employees1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.employees1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.fKSalesEmployees1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKSalesEmployees1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKEmployeesPositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddPosition = new System.Windows.Forms.Button();
            surnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            posIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingNavigator)).BeginInit();
            this.employees1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesEmployees1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesEmployees1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesPositionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(26, 90);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(50, 13);
            surnameLabel.TabIndex = 14;
            surnameLabel.Text = "surname:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 116);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "name:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(26, 142);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(61, 13);
            patronymicLabel.TabIndex = 18;
            patronymicLabel.Text = "patronymic:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(26, 168);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(37, 13);
            salaryLabel.TabIndex = 20;
            salaryLabel.Text = "salary:";
            // 
            // posIdLabel
            // 
            posIdLabel.AutoSize = true;
            posIdLabel.Location = new System.Drawing.Point(226, 89);
            posIdLabel.Name = "posIdLabel";
            posIdLabel.Size = new System.Drawing.Size(39, 13);
            posIdLabel.TabIndex = 22;
            posIdLabel.Text = "pos Id:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(448, 98);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(448, 146);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(448, 28);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 52);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(33, 273);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 11;
            this.buttonFirst.Text = "Первая";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(313, 273);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 11;
            this.buttonLast.Text = "Последняя";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrevios
            // 
            this.buttonPrevios.Location = new System.Drawing.Point(139, 273);
            this.buttonPrevios.Name = "buttonPrevios";
            this.buttonPrevios.Size = new System.Drawing.Size(75, 64);
            this.buttonPrevios.TabIndex = 11;
            this.buttonPrevios.Text = "<----";
            this.buttonPrevios.UseVisualStyleBackColor = true;
            this.buttonPrevios.Click += new System.EventHandler(this.buttonPrevios_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(220, 273);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 64);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "--->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // computerFirmDataSet
            // 
            this.computerFirmDataSet.DataSetName = "ComputerFirmDataSet";
            this.computerFirmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employees1BindingSource
            // 
            this.employees1BindingSource.DataMember = "Employees1";
            this.employees1BindingSource.DataSource = this.computerFirmDataSet;
            // 
            // employees1TableAdapter
            // 
            this.employees1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BasketTableAdapter = null;
            this.tableAdapterManager.DevicesTableAdapter = null;
            this.tableAdapterManager.Employees1TableAdapter = this.employees1TableAdapter;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.PositionsTableAdapter = this.positionsTableAdapter;
            this.tableAdapterManager.SalesTableAdapter = this.salesTableAdapter;
            this.tableAdapterManager.TypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DB_CourseProject.ComputerFirmDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // employees1BindingNavigator
            // 
            this.employees1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employees1BindingNavigator.BindingSource = this.employees1BindingSource;
            this.employees1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employees1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employees1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employees1BindingNavigatorSaveItem});
            this.employees1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employees1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employees1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employees1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employees1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employees1BindingNavigator.Name = "employees1BindingNavigator";
            this.employees1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employees1BindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.employees1BindingNavigator.TabIndex = 12;
            this.employees1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // employees1BindingNavigatorSaveItem
            // 
            this.employees1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employees1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employees1BindingNavigatorSaveItem.Image")));
            this.employees1BindingNavigatorSaveItem.Name = "employees1BindingNavigatorSaveItem";
            this.employees1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employees1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.employees1BindingNavigatorSaveItem.Click += new System.EventHandler(this.employees1BindingNavigatorSaveItem_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees1BindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(93, 87);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(121, 20);
            this.surnameTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees1BindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 113);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees1BindingSource, "patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(93, 139);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(121, 20);
            this.patronymicTextBox.TabIndex = 19;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employees1BindingSource, "salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(93, 165);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(121, 20);
            this.salaryTextBox.TabIndex = 21;
            // 
            // fKSalesEmployees1BindingSource
            // 
            this.fKSalesEmployees1BindingSource.DataMember = "FK_Sales_Employees1";
            this.fKSalesEmployees1BindingSource.DataSource = this.employees1BindingSource;
            // 
            // employees1BindingSource1
            // 
            this.employees1BindingSource1.DataMember = "Employees1";
            this.employees1BindingSource1.DataSource = this.computerFirmDataSet;
            // 
            // fKSalesEmployees1BindingSource1
            // 
            this.fKSalesEmployees1BindingSource1.DataMember = "FK_Sales_Employees1";
            this.fKSalesEmployees1BindingSource1.DataSource = this.employees1BindingSource1;
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "Positions";
            this.positionsBindingSource.DataSource = this.computerFirmDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employees1BindingSource, "posId", true));
            this.comboBox1.DataSource = this.positionsBindingSource;
            this.comboBox1.DisplayMember = "posName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "posId";
            // 
            // fKEmployeesPositionsBindingSource
            // 
            this.fKEmployeesPositionsBindingSource.DataMember = "FK_Employees_Positions";
            this.fKEmployeesPositionsBindingSource.DataSource = this.positionsBindingSource;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(327, 116);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(75, 39);
            this.buttonAddPosition.TabIndex = 24;
            this.buttonAddPosition.Text = "Добавить должность";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.buttonAddPosition_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.buttonAddPosition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(posIdLabel);
            this.Controls.Add(this.employees1BindingNavigator);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevios);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerFirmDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingNavigator)).EndInit();
            this.employees1BindingNavigator.ResumeLayout(false);
            this.employees1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesEmployees1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesEmployees1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEmployeesPositionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrevios;
        private System.Windows.Forms.Button buttonNext;
        private ComputerFirmDataSet computerFirmDataSet;
        private System.Windows.Forms.BindingSource employees1BindingSource;
        private ComputerFirmDataSetTableAdapters.Employees1TableAdapter employees1TableAdapter;
        private ComputerFirmDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employees1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employees1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private ComputerFirmDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesEmployees1BindingSource;
        private ComputerFirmDataSetTableAdapters.PositionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource employees1BindingSource1;
        private System.Windows.Forms.BindingSource fKSalesEmployees1BindingSource1;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKEmployeesPositionsBindingSource;
        private System.Windows.Forms.Button buttonAddPosition;
    }
}

