namespace RentCar.UI.Maintenances
{
    partial class FrmCarInspection
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
            this.chbHasTires = new System.Windows.Forms.CheckBox();
            this.nudFluelQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInspectionDate = new System.Windows.Forms.DateTimePicker();
            this.chbBackLeftTireState = new System.Windows.Forms.CheckBox();
            this.chbBackRightTireState = new System.Windows.Forms.CheckBox();
            this.chbFrontLeftTireState = new System.Windows.Forms.CheckBox();
            this.chbFrontRightTireState = new System.Windows.Forms.CheckBox();
            this.chbBrokenCrystal = new System.Windows.Forms.CheckBox();
            this.chbHasReplacementTires = new System.Windows.Forms.CheckBox();
            this.chbHasHydraulicJack = new System.Windows.Forms.CheckBox();
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
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.dgvCartInspections = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.tbpMantenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFluelQuantity)).BeginInit();
            this.tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartInspections)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMantenance
            // 
            this.tbpMantenance.Controls.Add(this.groupBox1);
            this.tbpMantenance.Location = new System.Drawing.Point(4, 25);
            this.tbpMantenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpMantenance.Name = "tbpMantenance";
            this.tbpMantenance.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpMantenance.Size = new System.Drawing.Size(849, 430);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(867, 398);
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
            this.panel2.Controls.Add(this.chbHasTires);
            this.panel2.Controls.Add(this.nudFluelQuantity);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpInspectionDate);
            this.panel2.Controls.Add(this.chbBackLeftTireState);
            this.panel2.Controls.Add(this.chbBackRightTireState);
            this.panel2.Controls.Add(this.chbFrontLeftTireState);
            this.panel2.Controls.Add(this.chbFrontRightTireState);
            this.panel2.Controls.Add(this.chbBrokenCrystal);
            this.panel2.Controls.Add(this.chbHasReplacementTires);
            this.panel2.Controls.Add(this.chbHasHydraulicJack);
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
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 370);
            this.panel2.TabIndex = 10;
            // 
            // chbHasTires
            // 
            this.chbHasTires.AutoSize = true;
            this.chbHasTires.Location = new System.Drawing.Point(539, 152);
            this.chbHasTires.Name = "chbHasTires";
            this.chbHasTires.Size = new System.Drawing.Size(99, 21);
            this.chbHasTires.TabIndex = 34;
            this.chbHasTires.Text = "Has Tires?";
            this.chbHasTires.UseVisualStyleBackColor = true;
            // 
            // nudFluelQuantity
            // 
            this.nudFluelQuantity.Location = new System.Drawing.Point(145, 171);
            this.nudFluelQuantity.Name = "nudFluelQuantity";
            this.nudFluelQuantity.Size = new System.Drawing.Size(267, 22);
            this.nudFluelQuantity.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "FluelCategory:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Inspection Date:";
            // 
            // dtpInspectionDate
            // 
            this.dtpInspectionDate.Location = new System.Drawing.Point(164, 130);
            this.dtpInspectionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInspectionDate.Name = "dtpInspectionDate";
            this.dtpInspectionDate.Size = new System.Drawing.Size(249, 22);
            this.dtpInspectionDate.TabIndex = 30;
            // 
            // chbBackLeftTireState
            // 
            this.chbBackLeftTireState.AutoSize = true;
            this.chbBackLeftTireState.Location = new System.Drawing.Point(231, 212);
            this.chbBackLeftTireState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBackLeftTireState.Name = "chbBackLeftTireState";
            this.chbBackLeftTireState.Size = new System.Drawing.Size(155, 21);
            this.chbBackLeftTireState.TabIndex = 29;
            this.chbBackLeftTireState.Text = "Back Left Tire State";
            this.chbBackLeftTireState.UseVisualStyleBackColor = true;
            // 
            // chbBackRightTireState
            // 
            this.chbBackRightTireState.AutoSize = true;
            this.chbBackRightTireState.Location = new System.Drawing.Point(33, 212);
            this.chbBackRightTireState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBackRightTireState.Name = "chbBackRightTireState";
            this.chbBackRightTireState.Size = new System.Drawing.Size(164, 21);
            this.chbBackRightTireState.TabIndex = 28;
            this.chbBackRightTireState.Text = "Back Right Tire State";
            this.chbBackRightTireState.UseVisualStyleBackColor = true;
            // 
            // chbFrontLeftTireState
            // 
            this.chbFrontLeftTireState.AutoSize = true;
            this.chbFrontLeftTireState.Location = new System.Drawing.Point(539, 222);
            this.chbFrontLeftTireState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbFrontLeftTireState.Name = "chbFrontLeftTireState";
            this.chbFrontLeftTireState.Size = new System.Drawing.Size(157, 21);
            this.chbFrontLeftTireState.TabIndex = 27;
            this.chbFrontLeftTireState.Text = "Front Left Tire State";
            this.chbFrontLeftTireState.UseVisualStyleBackColor = true;
            // 
            // chbFrontRightTireState
            // 
            this.chbFrontRightTireState.AutoSize = true;
            this.chbFrontRightTireState.Location = new System.Drawing.Point(539, 181);
            this.chbFrontRightTireState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbFrontRightTireState.Name = "chbFrontRightTireState";
            this.chbFrontRightTireState.Size = new System.Drawing.Size(166, 21);
            this.chbFrontRightTireState.TabIndex = 26;
            this.chbFrontRightTireState.Text = "Front Right Tire State";
            this.chbFrontRightTireState.UseVisualStyleBackColor = true;
            // 
            // chbBrokenCrystal
            // 
            this.chbBrokenCrystal.AutoSize = true;
            this.chbBrokenCrystal.Location = new System.Drawing.Point(539, 126);
            this.chbBrokenCrystal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbBrokenCrystal.Name = "chbBrokenCrystal";
            this.chbBrokenCrystal.Size = new System.Drawing.Size(155, 21);
            this.chbBrokenCrystal.TabIndex = 24;
            this.chbBrokenCrystal.Text = "Has BrokenCrystal?";
            this.chbBrokenCrystal.UseVisualStyleBackColor = true;
            // 
            // chbHasReplacementTires
            // 
            this.chbHasReplacementTires.AutoSize = true;
            this.chbHasReplacementTires.Location = new System.Drawing.Point(539, 82);
            this.chbHasReplacementTires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbHasReplacementTires.Name = "chbHasReplacementTires";
            this.chbHasReplacementTires.Size = new System.Drawing.Size(186, 21);
            this.chbHasReplacementTires.TabIndex = 22;
            this.chbHasReplacementTires.Text = "Has Replacement Tires?";
            this.chbHasReplacementTires.UseVisualStyleBackColor = true;
            // 
            // chbHasHydraulicJack
            // 
            this.chbHasHydraulicJack.AutoSize = true;
            this.chbHasHydraulicJack.Location = new System.Drawing.Point(539, 41);
            this.chbHasHydraulicJack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbHasHydraulicJack.Name = "chbHasHydraulicJack";
            this.chbHasHydraulicJack.Size = new System.Drawing.Size(155, 21);
            this.chbHasHydraulicJack.TabIndex = 20;
            this.chbHasHydraulicJack.Text = "Has HydraulicJack?";
            this.chbHasHydraulicJack.UseVisualStyleBackColor = true;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(347, 85);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(67, 23);
            this.btnSelectClient.TabIndex = 19;
            this.btnSelectClient.Text = "Select";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(145, 86);
            this.txtClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(181, 22);
            this.txtClient.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Client:";
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(347, 46);
            this.btnSelectCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(67, 23);
            this.btnSelectCar.TabIndex = 13;
            this.btnSelectCar.Text = "Select";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(145, 47);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.ReadOnly = true;
            this.txtCarName.Size = new System.Drawing.Size(181, 22);
            this.txtCarName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Car:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            this.label3.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 310);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(444, 310);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 2);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 22);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(303, 310);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(164, 310);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(89, 17);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(200, 24);
            this.cbEmployee.TabIndex = 8;
            // 
            // tbpList
            // 
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
            this.tbpList.Controls.Add(this.dgvCartInspections);
            this.tbpList.Controls.Add(this.btnDelete);
            this.tbpList.Controls.Add(this.btnSearch);
            this.tbpList.Controls.Add(this.label2);
            this.tbpList.Location = new System.Drawing.Point(4, 25);
            this.tbpList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpList.Size = new System.Drawing.Size(1080, 519);
            this.tbpList.TabIndex = 0;
            this.tbpList.Text = "List";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // cbCars
            // 
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(396, 15);
            this.cbCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(200, 24);
            this.cbCars.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Employee:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(927, 12);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 32);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(924, 109);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(16, 17);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "0";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(7, 113);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(71, 21);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Delete";
            this.chkDelete.Click += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // dgvCartInspections
            // 
            this.dgvCartInspections.AllowUserToAddRows = false;
            this.dgvCartInspections.AllowUserToDeleteRows = false;
            this.dgvCartInspections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCartInspections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCartInspections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartInspections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvCartInspections.Location = new System.Drawing.Point(7, 151);
            this.dgvCartInspections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCartInspections.Name = "dgvCartInspections";
            this.dgvCartInspections.ReadOnly = true;
            this.dgvCartInspections.RowHeadersWidth = 51;
            this.dgvCartInspections.RowTemplate.Height = 24;
            this.dgvCartInspections.Size = new System.Drawing.Size(1067, 363);
            this.dgvCartInspections.TabIndex = 4;
            this.dgvCartInspections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartInspections_CellContentClick);
            this.dgvCartInspections.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartInspections_DoubleClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 78;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(814, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(702, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 548);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Inspection";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 611);
            this.panel1.TabIndex = 2;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(89, 54);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpFrom.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(396, 54);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 22);
            this.dtpTo.TabIndex = 13;
            // 
            // FrmCarInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCarInspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inspection";
            this.Load += new System.EventHandler(this.FrmCarInspection_Load);
            this.tbpMantenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFluelQuantity)).EndInit();
            this.tbpList.ResumeLayout(false);
            this.tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartInspections)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCartInspections;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Delete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMessage;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbFrontRightTireState;
        private System.Windows.Forms.CheckBox chbBrokenCrystal;
        private System.Windows.Forms.CheckBox chbHasReplacementTires;
        private System.Windows.Forms.CheckBox chbHasHydraulicJack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInspectionDate;
        private System.Windows.Forms.CheckBox chbBackLeftTireState;
        private System.Windows.Forms.CheckBox chbBackRightTireState;
        private System.Windows.Forms.CheckBox chbFrontLeftTireState;
        private System.Windows.Forms.NumericUpDown nudFluelQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbHasTires;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label9;
    }
}