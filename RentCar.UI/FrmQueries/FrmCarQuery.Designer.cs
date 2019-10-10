namespace RentCar.UI.FrmQueries
{
    partial class FrmCarQuery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCarModelFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrandFilter = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTotalRegister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblTotalRegister);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCarModelFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBrandFilter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvCars);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 448);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Model:";
            // 
            // cbCarModelFilter
            // 
            this.cbCarModelFilter.FormattingEnabled = true;
            this.cbCarModelFilter.Location = new System.Drawing.Point(232, 11);
            this.cbCarModelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbCarModelFilter.Name = "cbCarModelFilter";
            this.cbCarModelFilter.Size = new System.Drawing.Size(130, 21);
            this.cbCarModelFilter.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brand:";
            // 
            // cbBrandFilter
            // 
            this.cbBrandFilter.FormattingEnabled = true;
            this.cbBrandFilter.Location = new System.Drawing.Point(57, 11);
            this.cbBrandFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbBrandFilter.Name = "cbBrandFilter";
            this.cbBrandFilter.Size = new System.Drawing.Size(117, 21);
            this.cbBrandFilter.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by:";
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(12, 87);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(724, 350);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(403, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 19;
            // 
            // lblTotalRegister
            // 
            this.lblTotalRegister.AutoSize = true;
            this.lblTotalRegister.Location = new System.Drawing.Point(570, 51);
            this.lblTotalRegister.Name = "lblTotalRegister";
            this.lblTotalRegister.Size = new System.Drawing.Size(84, 13);
            this.lblTotalRegister.TabIndex = 20;
            this.lblTotalRegister.Text = "Total Registers: ";
            // 
            // FrmCarQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCarQuery";
            this.Text = "FrmCarQuery";
            this.Load += new System.EventHandler(this.FrmCarQuery_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCarModelFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBrandFilter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotalRegister;
    }
}