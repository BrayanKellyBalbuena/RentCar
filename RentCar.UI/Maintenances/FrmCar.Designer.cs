namespace RentCar.UI.Maintenances
{
    partial class FrmCar
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
            //if (disposing && (components != null))
            //{
            //    components.Dispose();
            //}
            //base.Dispose(disposing);

            Hide();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpList = new System.Windows.Forms.TabPage();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFluelCategoryFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarModelFilter = new System.Windows.Forms.ComboBox();
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrandFilter = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tbpMantenance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFluelCategory = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtChassisNumber = new System.Windows.Forms.TextBox();
            this.cbCarCategory = new System.Windows.Forms.ComboBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlacaNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEmployee = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.tbpMantenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 423);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpList);
            this.tabControl1.Controls.Add(this.tbpMantenance);
            this.tabControl1.Location = new System.Drawing.Point(15, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 372);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpList
            // 
            this.tbpList.Controls.Add(this.comboBox7);
            this.tbpList.Controls.Add(this.label8);
            this.tbpList.Controls.Add(this.cbFluelCategoryFilter);
            this.tbpList.Controls.Add(this.label7);
            this.tbpList.Controls.Add(this.label6);
            this.tbpList.Controls.Add(this.label5);
            this.tbpList.Controls.Add(this.cbCarModelFilter);
            this.tbpList.Controls.Add(this.cbCategoryFilter);
            this.tbpList.Controls.Add(this.label2);
            this.tbpList.Controls.Add(this.cbBrandFilter);
            this.tbpList.Controls.Add(this.btnPrint);
            this.tbpList.Controls.Add(this.lblTotalRows);
            this.tbpList.Controls.Add(this.chkDelete);
            this.tbpList.Controls.Add(this.dgvCars);
            this.tbpList.Controls.Add(this.btnDelete);
            this.tbpList.Controls.Add(this.btnSearch);
            this.tbpList.Controls.Add(this.txtSearch);
            this.tbpList.Location = new System.Drawing.Point(4, 22);
            this.tbpList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Size = new System.Drawing.Size(544, 346);
            this.tbpList.TabIndex = 0;
            this.tbpList.Text = "List";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(59, 80);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(117, 21);
            this.comboBox7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Filter:";
            // 
            // cbFluelCategoryFilter
            // 
            this.cbFluelCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFluelCategoryFilter.FormattingEnabled = true;
            this.cbFluelCategoryFilter.Location = new System.Drawing.Point(315, 43);
            this.cbFluelCategoryFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFluelCategoryFilter.Name = "cbFluelCategoryFilter";
            this.cbFluelCategoryFilter.Size = new System.Drawing.Size(130, 21);
            this.cbFluelCategoryFilter.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fluel Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // cbCarModelFilter
            // 
            this.cbCarModelFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarModelFilter.FormattingEnabled = true;
            this.cbCarModelFilter.Location = new System.Drawing.Point(315, 15);
            this.cbCarModelFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCarModelFilter.Name = "cbCarModelFilter";
            this.cbCarModelFilter.Size = new System.Drawing.Size(130, 21);
            this.cbCarModelFilter.TabIndex = 11;
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(59, 46);
            this.cbCategoryFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(117, 21);
            this.cbCategoryFilter.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brand:";
            // 
            // cbBrandFilter
            // 
            this.cbBrandFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandFilter.FormattingEnabled = true;
            this.cbBrandFilter.Location = new System.Drawing.Point(59, 15);
            this.cbBrandFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBrandFilter.Name = "cbBrandFilter";
            this.cbBrandFilter.Size = new System.Drawing.Size(117, 21);
            this.cbBrandFilter.TabIndex = 8;
            this.cbBrandFilter.SelectedIndexChanged += new System.EventHandler(this.cbBrandFilter_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(456, 77);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 26);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(330, 132);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(76, 13);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "Total registers:";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(5, 132);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Delete";
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvCars.Location = new System.Drawing.Point(5, 167);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(536, 177);
            this.dgvCars.TabIndex = 4;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentClick);
            this.dgvCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_DoubleClick);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 63;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 77);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(190, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // tbpMantenance
            // 
            this.tbpMantenance.Controls.Add(this.groupBox1);
            this.tbpMantenance.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpMantenance.Name = "tbpMantenance";
            this.tbpMantenance.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpMantenance.Size = new System.Drawing.Size(544, 346);
            this.tbpMantenance.TabIndex = 1;
            this.tbpMantenance.Text = "Mantenance";
            this.tbpMantenance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbFluelCategory);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbCarModel);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtChassisNumber);
            this.groupBox1.Controls.Add(this.cbCarCategory);
            this.groupBox1.Controls.Add(this.cbBrand);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPlacaNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEngineNumber);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdEmployee);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(536, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // cbFluelCategory
            // 
            this.cbFluelCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFluelCategory.FormattingEnabled = true;
            this.cbFluelCategory.Location = new System.Drawing.Point(364, 136);
            this.cbFluelCategory.Name = "cbFluelCategory";
            this.cbFluelCategory.Size = new System.Drawing.Size(149, 21);
            this.cbFluelCategory.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fluel Category:";
            // 
            // cbCarModel
            // 
            this.cbCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Location = new System.Drawing.Point(105, 137);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(149, 21);
            this.cbCarModel.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Chassis Number:";
            // 
            // txtChassisNumber
            // 
            this.txtChassisNumber.Location = new System.Drawing.Point(364, 54);
            this.txtChassisNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChassisNumber.Name = "txtChassisNumber";
            this.txtChassisNumber.Size = new System.Drawing.Size(149, 20);
            this.txtChassisNumber.TabIndex = 22;
            this.txtChassisNumber.TextChanged += new System.EventHandler(this.txtChassisNumber_TextChanged);
            // 
            // cbCarCategory
            // 
            this.cbCarCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarCategory.FormattingEnabled = true;
            this.cbCarCategory.Location = new System.Drawing.Point(105, 110);
            this.cbCarCategory.Name = "cbCarCategory";
            this.cbCarCategory.Size = new System.Drawing.Size(149, 21);
            this.cbCarCategory.TabIndex = 21;
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(364, 108);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(149, 21);
            this.cbBrand.TabIndex = 20;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Car Category:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Placa Number:";
            // 
            // txtPlacaNumber
            // 
            this.txtPlacaNumber.Location = new System.Drawing.Point(105, 85);
            this.txtPlacaNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlacaNumber.MaxLength = 7;
            this.txtPlacaNumber.Name = "txtPlacaNumber";
            this.txtPlacaNumber.Size = new System.Drawing.Size(149, 20);
            this.txtPlacaNumber.TabIndex = 14;
            this.txtPlacaNumber.TextChanged += new System.EventHandler(this.txtPlacaNumber_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Engine Number:";
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(364, 83);
            this.txtEngineNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(149, 20);
            this.txtEngineNumber.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(322, 111);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(38, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 20);
            this.txtName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            this.label3.Visible = false;
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Location = new System.Drawing.Point(105, 17);
            this.txtIdEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(149, 20);
            this.txtIdEmployee.TabIndex = 4;
            this.txtIdEmployee.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(385, 285);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(278, 285);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 285);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(68, 285);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 422);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCar";
            this.Text = "FrmCar";
            this.Load += new System.EventHandler(this.FrmCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbpList.ResumeLayout(false);
            this.tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.tbpMantenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpList;
        private System.Windows.Forms.ComboBox cbBrandFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tbpMantenance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.ToolTip ttMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarModelFilter;
        private System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFluelCategoryFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlacaNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFluelCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCarModel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtChassisNumber;
        private System.Windows.Forms.ComboBox cbCarCategory;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}