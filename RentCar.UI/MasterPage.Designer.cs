namespace RentCar.UI
{
    partial class MasterPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carBrandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluelCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCarToolStripMenuItem,
            this.maintenancesToolStripMenuItem,
            this.carInspectionToolStripMenuItem,
            this.rentsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rentCarToolStripMenuItem
            // 
            this.rentCarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.rentCarToolStripMenuItem.Name = "rentCarToolStripMenuItem";
            this.rentCarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.rentCarToolStripMenuItem.Text = "Rent Car";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintenancesToolStripMenuItem
            // 
            this.maintenancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carToolStripMenuItem,
            this.carBrandsToolStripMenuItem,
            this.carModelsToolStripMenuItem,
            this.fluelCategoriesToolStripMenuItem,
            this.carCategoriesToolStripMenuItem,
            this.personTypesToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.maintenancesToolStripMenuItem.Name = "maintenancesToolStripMenuItem";
            this.maintenancesToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.maintenancesToolStripMenuItem.Text = "Maintenances";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.carToolStripMenuItem.Text = "Car";
            this.carToolStripMenuItem.Click += new System.EventHandler(this.carToolStripMenuItem_Click);
            // 
            // carBrandsToolStripMenuItem
            // 
            this.carBrandsToolStripMenuItem.Name = "carBrandsToolStripMenuItem";
            this.carBrandsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.carBrandsToolStripMenuItem.Text = "Car Brands";
            this.carBrandsToolStripMenuItem.Click += new System.EventHandler(this.carBrandsToolStripMenuItem_Click);
            // 
            // carModelsToolStripMenuItem
            // 
            this.carModelsToolStripMenuItem.Name = "carModelsToolStripMenuItem";
            this.carModelsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.carModelsToolStripMenuItem.Text = "Car Models";
            // 
            // fluelCategoriesToolStripMenuItem
            // 
            this.fluelCategoriesToolStripMenuItem.Name = "fluelCategoriesToolStripMenuItem";
            this.fluelCategoriesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.fluelCategoriesToolStripMenuItem.Text = "Fluel Categories";
            // 
            // carCategoriesToolStripMenuItem
            // 
            this.carCategoriesToolStripMenuItem.Name = "carCategoriesToolStripMenuItem";
            this.carCategoriesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.carCategoriesToolStripMenuItem.Text = "Car Categories";
            this.carCategoriesToolStripMenuItem.Click += new System.EventHandler(this.carCategoriesToolStripMenuItem_Click);
            // 
            // personTypesToolStripMenuItem
            // 
            this.personTypesToolStripMenuItem.Name = "personTypesToolStripMenuItem";
            this.personTypesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.personTypesToolStripMenuItem.Text = "Person Types";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // carInspectionToolStripMenuItem
            // 
            this.carInspectionToolStripMenuItem.Name = "carInspectionToolStripMenuItem";
            this.carInspectionToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.carInspectionToolStripMenuItem.Text = "Car Inspections";
            // 
            // rentsToolStripMenuItem
            // 
            this.rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            this.rentsToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.rentsToolStripMenuItem.Text = "Rents And Devolutions";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterPage";
            this.Text = "Rent Car";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carBrandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carModelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluelCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

