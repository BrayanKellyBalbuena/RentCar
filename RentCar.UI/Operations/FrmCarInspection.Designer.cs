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
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInspectionDate = new System.Windows.Forms.DateTimePicker();
            this.chbBackLeftTireState = new System.Windows.Forms.CheckBox();
            this.chbBackRightTireState = new System.Windows.Forms.CheckBox();
            this.chbFrontLeftTireState = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.chbFrontRightTireState = new System.Windows.Forms.CheckBox();
            this.chbHasReplacementTires = new System.Windows.Forms.CheckBox();
            this.chbHasHydraulicJack = new System.Windows.Forms.CheckBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtIdCarModel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.tbpList = new System.Windows.Forms.TabPage();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.dgvCarModels = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpMantenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarModels)).BeginInit();
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
            this.tbpMantenance.Size = new System.Drawing.Size(635, 347);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(650, 323);
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpInspectionDate);
            this.panel2.Controls.Add(this.chbBackLeftTireState);
            this.panel2.Controls.Add(this.chbBackRightTireState);
            this.panel2.Controls.Add(this.chbFrontLeftTireState);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.chbFrontRightTireState);
            this.panel2.Controls.Add(this.chbHasReplacementTires);
            this.panel2.Controls.Add(this.chbHasHydraulicJack);
            this.panel2.Controls.Add(this.btnSelectClient);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSelectCar);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.txtIdCarModel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Location = new System.Drawing.Point(0, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 301);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Inspection Date:";
            // 
            // dtpInspectionDate
            // 
            this.dtpInspectionDate.Location = new System.Drawing.Point(123, 106);
            this.dtpInspectionDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpInspectionDate.Name = "dtpInspectionDate";
            this.dtpInspectionDate.Size = new System.Drawing.Size(188, 20);
            this.dtpInspectionDate.TabIndex = 30;
            // 
            // chbBackLeftTireState
            // 
            this.chbBackLeftTireState.AutoSize = true;
            this.chbBackLeftTireState.Location = new System.Drawing.Point(37, 167);
            this.chbBackLeftTireState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbBackLeftTireState.Name = "chbBackLeftTireState";
            this.chbBackLeftTireState.Size = new System.Drawing.Size(121, 17);
            this.chbBackLeftTireState.TabIndex = 29;
            this.chbBackLeftTireState.Text = "Back Left Tire State";
            this.chbBackLeftTireState.UseVisualStyleBackColor = true;
            // 
            // chbBackRightTireState
            // 
            this.chbBackRightTireState.AutoSize = true;
            this.chbBackRightTireState.Location = new System.Drawing.Point(37, 134);
            this.chbBackRightTireState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbBackRightTireState.Name = "chbBackRightTireState";
            this.chbBackRightTireState.Size = new System.Drawing.Size(128, 17);
            this.chbBackRightTireState.TabIndex = 28;
            this.chbBackRightTireState.Text = "Back Right Tire State";
            this.chbBackRightTireState.UseVisualStyleBackColor = true;
            // 
            // chbFrontLeftTireState
            // 
            this.chbFrontLeftTireState.AutoSize = true;
            this.chbFrontLeftTireState.Location = new System.Drawing.Point(404, 180);
            this.chbFrontLeftTireState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbFrontLeftTireState.Name = "chbFrontLeftTireState";
            this.chbFrontLeftTireState.Size = new System.Drawing.Size(120, 17);
            this.chbFrontLeftTireState.TabIndex = 27;
            this.chbFrontLeftTireState.Text = "Front Left Tire State";
            this.chbFrontLeftTireState.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(404, 147);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 17);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.Text = "Front Right Tire State";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // chbFrontRightTireState
            // 
            this.chbFrontRightTireState.AutoSize = true;
            this.chbFrontRightTireState.Location = new System.Drawing.Point(404, 109);
            this.chbFrontRightTireState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbFrontRightTireState.Name = "chbFrontRightTireState";
            this.chbFrontRightTireState.Size = new System.Drawing.Size(119, 17);
            this.chbFrontRightTireState.TabIndex = 24;
            this.chbFrontRightTireState.Text = "Has BrokenCrystal?";
            this.chbFrontRightTireState.UseVisualStyleBackColor = true;
            // 
            // chbHasReplacementTires
            // 
            this.chbHasReplacementTires.AutoSize = true;
            this.chbHasReplacementTires.Location = new System.Drawing.Point(404, 72);
            this.chbHasReplacementTires.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbHasReplacementTires.Name = "chbHasReplacementTires";
            this.chbHasReplacementTires.Size = new System.Drawing.Size(143, 17);
            this.chbHasReplacementTires.TabIndex = 22;
            this.chbHasReplacementTires.Text = "Has Replacement Tires?";
            this.chbHasReplacementTires.UseVisualStyleBackColor = true;
            // 
            // chbHasHydraulicJack
            // 
            this.chbHasHydraulicJack.AutoSize = true;
            this.chbHasHydraulicJack.Location = new System.Drawing.Point(404, 33);
            this.chbHasHydraulicJack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbHasHydraulicJack.Name = "chbHasHydraulicJack";
            this.chbHasHydraulicJack.Size = new System.Drawing.Size(121, 17);
            this.chbHasHydraulicJack.TabIndex = 20;
            this.chbHasHydraulicJack.Text = "Has HydraulicJack?";
            this.chbHasHydraulicJack.UseVisualStyleBackColor = true;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(260, 69);
            this.btnSelectClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(50, 19);
            this.btnSelectClient.TabIndex = 19;
            this.btnSelectClient.Text = "Select";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 70);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Client:";
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(260, 37);
            this.btnSelectCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(50, 19);
            this.btnSelectCar.TabIndex = 13;
            this.btnSelectCar.Text = "Search";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Car:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id:";
            this.label3.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 252);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(333, 252);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            // 
            // txtIdCarModel
            // 
            this.txtIdCarModel.Location = new System.Drawing.Point(37, 2);
            this.txtIdCarModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCarModel.Name = "txtIdCarModel";
            this.txtIdCarModel.Size = new System.Drawing.Size(223, 20);
            this.txtIdCarModel.TabIndex = 4;
            this.txtIdCarModel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(227, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(123, 252);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(67, 14);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(110, 21);
            this.cbEmployee.TabIndex = 8;
            // 
            // tbpList
            // 
            this.tbpList.Controls.Add(this.cbCars);
            this.tbpList.Controls.Add(this.label6);
            this.tbpList.Controls.Add(this.cbEmployee);
            this.tbpList.Controls.Add(this.btnPrint);
            this.tbpList.Controls.Add(this.lblTotalRows);
            this.tbpList.Controls.Add(this.chkDelete);
            this.tbpList.Controls.Add(this.dgvCarModels);
            this.tbpList.Controls.Add(this.btnDelete);
            this.tbpList.Controls.Add(this.btnSearch);
            this.tbpList.Controls.Add(this.label2);
            this.tbpList.Location = new System.Drawing.Point(4, 22);
            this.tbpList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpList.Size = new System.Drawing.Size(635, 347);
            this.tbpList.TabIndex = 0;
            this.tbpList.Text = "List";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // cbCars
            // 
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Location = new System.Drawing.Point(229, 14);
            this.cbCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(110, 21);
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
            this.btnPrint.Location = new System.Drawing.Point(567, 10);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(62, 26);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Location = new System.Drawing.Point(509, 48);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(13, 13);
            this.lblTotalRows.TabIndex = 6;
            this.lblTotalRows.Text = "0";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(8, 47);
            this.chkDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 5;
            this.chkDelete.Text = "Delete";
            // 
            // dgvCarModels
            // 
            this.dgvCarModels.AllowUserToAddRows = false;
            this.dgvCarModels.AllowUserToDeleteRows = false;
            this.dgvCarModels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCarModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarModels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvCarModels.Location = new System.Drawing.Point(5, 76);
            this.dgvCarModels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCarModels.Name = "dgvCarModels";
            this.dgvCarModels.ReadOnly = true;
            this.dgvCarModels.RowTemplate.Height = 24;
            this.dgvCarModels.Size = new System.Drawing.Size(627, 269);
            this.dgvCarModels.TabIndex = 4;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 63;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(482, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(398, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 16);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
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
            this.panel1.Location = new System.Drawing.Point(1, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 424);
            this.panel1.TabIndex = 2;
            // 
            // FrmCarInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 431);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCarInspection";
            this.Text = "Car Inspection";
            this.tbpMantenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbpList.ResumeLayout(false);
            this.tbpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarModels)).EndInit();
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
        private System.Windows.Forms.TextBox txtIdCarModel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.TabPage tbpList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.DataGridView dgvCarModels;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox chbFrontRightTireState;
        private System.Windows.Forms.CheckBox chbHasReplacementTires;
        private System.Windows.Forms.CheckBox chbHasHydraulicJack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInspectionDate;
        private System.Windows.Forms.CheckBox chbBackLeftTireState;
        private System.Windows.Forms.CheckBox chbBackRightTireState;
        private System.Windows.Forms.CheckBox chbFrontLeftTireState;
    }
}