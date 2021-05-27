namespace RentCar.UI.Maintenances
{
    partial class FrmRentDevolution
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
            this.tbpMantenance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nupDayQuantiy = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComentary = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDevolutionDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.tbpList = new System.Windows.Forms.TabPage();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.dgvRentDevolutions = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMantenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDayQuantiy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentDevolutions)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMantenance
            // 
            this.tbpMantenance.Controls.Add(this.groupBox1);
            this.tbpMantenance.Location = new System.Drawing.Point(4, 22);
            this.tbpMantenance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpMantenance.Name = "tbpMantenance";
            this.tbpMantenance.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpMantenance.Size = new System.Drawing.Size(715, 466);
            this.tbpMantenance.TabIndex = 1;
            this.tbpMantenance.Text = "Mantenance";
            this.tbpMantenance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(67, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(557, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.nupDayQuantiy);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtComentary);
            this.panel2.Controls.Add(this.nudAmount);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpDevolutionDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpRentDate);
            this.panel2.Controls.Add(this.btnSelectClient);
            this.panel2.Controls.Add(this.txtClient);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSelectCar);
            this.panel2.Controls.Add(this.txtCarName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 420);
            this.panel2.TabIndex = 10;
            // 
            // nupDayQuantiy
            // 
            this.nupDayQuantiy.Location = new System.Drawing.Point(208, 230);
            this.nupDayQuantiy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupDayQuantiy.Name = "nupDayQuantiy";
            this.nupDayQuantiy.Size = new System.Drawing.Size(200, 20);
            this.nupDayQuantiy.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Day Quantity:";
            // 
            // txtComentary
            // 
            this.txtComentary.Location = new System.Drawing.Point(207, 269);
            this.txtComentary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentary.MaxLength = 1000;
            this.txtComentary.Multiline = true;
            this.txtComentary.Name = "txtComentary";
            this.txtComentary.Size = new System.Drawing.Size(203, 78);
            this.txtComentary.TabIndex = 38;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(207, 192);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(200, 20);
            this.nudAmount.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Amount per day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Devolution Date:";
            // 
            // dtpDevolutionDate
            // 
            this.dtpDevolutionDate.Location = new System.Drawing.Point(207, 155);
            this.dtpDevolutionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDevolutionDate.Name = "dtpDevolutionDate";
            this.dtpDevolutionDate.Size = new System.Drawing.Size(201, 20);
            this.dtpDevolutionDate.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comentary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Rent Date:";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Location = new System.Drawing.Point(207, 123);
            this.dtpRentDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(201, 20);
            this.dtpRentDate.TabIndex = 30;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(358, 86);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(50, 19);
            this.btnSelectClient.TabIndex = 19;
            this.btnSelectClient.Text = "Select";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(207, 87);
            this.txtClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(137, 20);
            this.txtClient.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Client:";
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(358, 54);
            this.btnSelectCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(50, 19);
            this.btnSelectCar.TabIndex = 13;
            this.btnSelectCar.Text = "Select";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(207, 55);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.ReadOnly = true;
            this.txtCarName.Size = new System.Drawing.Size(137, 20);
            this.txtCarName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Car:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            this.label3.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 381);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(326, 381);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(135, 19);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(223, 20);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 381);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(116, 381);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(67, 14);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(151, 21);
            this.cbEmployee.TabIndex = 8;
            // 
            // tbpList
            // 
            this.tbpList.Controls.Add(this.btnDevolucion);
            this.tbpList.Controls.Add(this.label10);
            this.tbpList.Controls.Add(this.dtpTo);
            this.tbpList.Controls.Add(this.label9);
            this.tbpList.Controls.Add(this.dtpFrom);
            this.tbpList.Controls.Add(this.cbCars);
            this.tbpList.Controls.Add(this.label6);
            this.tbpList.Controls.Add(this.cbEmployee);
            this.tbpList.Controls.Add(this.btnPrint);
            this.tbpList.Controls.Add(this.lblTotalRows);
            this.tbpList.Controls.Add(this.chkDelete);
            this.tbpList.Controls.Add(this.dgvRentDevolutions);
            this.tbpList.Controls.Add(this.btnDelete);
            this.tbpList.Controls.Add(this.btnSearch);
            this.tbpList.Controls.Add(this.label2);
            this.tbpList.Location = new System.Drawing.Point(4, 22);
            this.tbpList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Size = new System.Drawing.Size(715, 466);
            this.tbpList.TabIndex = 0;
            this.tbpList.Text = "List";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(478, 48);
            this.btnDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(81, 26);
            this.btnDevolucion.TabIndex = 15;
            this.btnDevolucion.Text = "Devolucion";
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(297, 44);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(151, 20);
            this.dtpTo.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(67, 44);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(151, 20);
            this.dtpFrom.TabIndex = 11;
            // 
            // cbCars
            // 
            this.cbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(297, 12);
            this.cbCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(151, 21);
            this.cbCars.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Employee:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(645, 10);
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
            this.lblTotalRows.Location = new System.Drawing.Point(643, 92);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "0";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(5, 92);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Delete";
            this.chkDelete.Click += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // dgvRentDevolutions
            // 
            this.dgvRentDevolutions.AllowUserToAddRows = false;
            this.dgvRentDevolutions.AllowUserToDeleteRows = false;
            this.dgvRentDevolutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentDevolutions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRentDevolutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentDevolutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvRentDevolutions.Location = new System.Drawing.Point(5, 123);
            this.dgvRentDevolutions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRentDevolutions.Name = "dgvRentDevolutions";
            this.dgvRentDevolutions.ReadOnly = true;
            this.dgvRentDevolutions.RowHeadersWidth = 51;
            this.dgvRentDevolutions.RowTemplate.Height = 24;
            this.dgvRentDevolutions.Size = new System.Drawing.Size(707, 342);
            this.dgvRentDevolutions.TabIndex = 4;
            this.dgvRentDevolutions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentDevolution_CellContentClick);
            this.dgvRentDevolutions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentDevolution_DoubleClick);
            // 
            // Delete
            // 
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
            this.btnDelete.Location = new System.Drawing.Point(560, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(476, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Car:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpList);
            this.tabControl1.Controls.Add(this.tbpMantenance);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 496);
            this.panel1.TabIndex = 2;
            // 
            // FrmRentDevolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRentDevolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent and Devolution";
            this.Load += new System.EventHandler(this.FrmRentDevolution_Load);
            this.tbpMantenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDayQuantiy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.tbpList.ResumeLayout(false);
            this.tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentDevolutions)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpMantenance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.TabPage tbpList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.DataGridView dgvRentDevolutions;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip ttMessage;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDevolutionDate;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComentary;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.NumericUpDown nupDayQuantiy;
        private System.Windows.Forms.Label label12;
    }
}