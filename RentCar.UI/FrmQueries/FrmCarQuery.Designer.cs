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
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblTotalRegister = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCarModelFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBrandFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.lblTotalRegister);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCarModelFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBrandFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvCars);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 551);
            this.panel1.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Name",
            "Placa"});
            this.cbFilter.Location = new System.Drawing.Point(76, 53);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(172, 24);
            this.cbFilter.TabIndex = 21;
            // 
            // lblTotalRegister
            // 
            this.lblTotalRegister.AutoSize = true;
            this.lblTotalRegister.Location = new System.Drawing.Point(760, 63);
            this.lblTotalRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRegister.Name = "lblTotalRegister";
            this.lblTotalRegister.Size = new System.Drawing.Size(112, 17);
            this.lblTotalRegister.TabIndex = 20;
            this.lblTotalRegister.Text = "Total Registers: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(255, 55);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 22);
            this.txtFilter.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Model:";
            // 
            // cbCarModelFilter
            // 
            this.cbCarModelFilter.FormattingEnabled = true;
            this.cbCarModelFilter.Location = new System.Drawing.Point(309, 14);
            this.cbCarModelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCarModelFilter.Name = "cbCarModelFilter";
            this.cbCarModelFilter.Size = new System.Drawing.Size(172, 24);
            this.cbCarModelFilter.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brand:";
            // 
            // cbBrandFilter
            // 
            this.cbBrandFilter.FormattingEnabled = true;
            this.cbBrandFilter.Location = new System.Drawing.Point(76, 14);
            this.cbBrandFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBrandFilter.Name = "cbBrandFilter";
            this.cbBrandFilter.Size = new System.Drawing.Size(155, 24);
            this.cbBrandFilter.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by:";
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(16, 107);
            this.dgvCars.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.Size = new System.Drawing.Size(965, 431);
            this.dgvCars.TabIndex = 0;
            this.dgvCars.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellContentDoubleClick);
            // 
            // FrmCarQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCarModelFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBrandFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTotalRegister;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}