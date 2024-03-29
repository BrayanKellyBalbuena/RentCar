﻿namespace RentCar.UI
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
            this.carInspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentAndDevolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpsSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCarToolStripMenuItem,
            this.maintenancesToolStripMenuItem,
            this.carInspectionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.tpsSecurity});
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
            this.carModelsToolStripMenuItem.Click += new System.EventHandler(this.carModelsToolStripMenuItem_Click);
            // 
            // fluelCategoriesToolStripMenuItem
            // 
            this.fluelCategoriesToolStripMenuItem.Name = "fluelCategoriesToolStripMenuItem";
            this.fluelCategoriesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.fluelCategoriesToolStripMenuItem.Text = "Fluel Categories";
            this.fluelCategoriesToolStripMenuItem.Click += new System.EventHandler(this.fluelCategoriesToolStripMenuItem_Click);
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
            this.personTypesToolStripMenuItem.Click += new System.EventHandler(this.personTypesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // carInspectionToolStripMenuItem
            // 
            this.carInspectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carInspectionsToolStripMenuItem,
            this.rentToolStripMenuItem});
            this.carInspectionToolStripMenuItem.Name = "carInspectionToolStripMenuItem";
            this.carInspectionToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.carInspectionToolStripMenuItem.Text = "Car Operations";
            // 
            // carInspectionsToolStripMenuItem
            // 
            this.carInspectionsToolStripMenuItem.Name = "carInspectionsToolStripMenuItem";
            this.carInspectionsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.carInspectionsToolStripMenuItem.Text = "Car inspections";
            this.carInspectionsToolStripMenuItem.Click += new System.EventHandler(this.carInspectionsToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.rentToolStripMenuItem.Text = "Rent  & Devolution";
            this.rentToolStripMenuItem.Click += new System.EventHandler(this.rentToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectionsToolStripMenuItem,
            this.rentAndDevolutionToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // inspectionsToolStripMenuItem
            // 
            this.inspectionsToolStripMenuItem.Name = "inspectionsToolStripMenuItem";
            this.inspectionsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.inspectionsToolStripMenuItem.Text = "Inspections";
            this.inspectionsToolStripMenuItem.Click += new System.EventHandler(this.inspectionsToolStripMenuItem_Click);
            // 
            // rentAndDevolutionToolStripMenuItem
            // 
            this.rentAndDevolutionToolStripMenuItem.Name = "rentAndDevolutionToolStripMenuItem";
            this.rentAndDevolutionToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.rentAndDevolutionToolStripMenuItem.Text = "Rent And Devolution";
            this.rentAndDevolutionToolStripMenuItem.Click += new System.EventHandler(this.rentAndDevolutionToolStripMenuItem_Click);
            // 
            // tpsSecurity
            // 
            this.tpsSecurity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem1,
            this.usersToolStripMenuItem});
            this.tpsSecurity.Enabled = false;
            this.tpsSecurity.Name = "tpsSecurity";
            this.tpsSecurity.Size = new System.Drawing.Size(73, 24);
            this.tpsSecurity.Text = "Security";
            // 
            // employeesToolStripMenuItem1
            // 
            this.employeesToolStripMenuItem1.Name = "employeesToolStripMenuItem1";
            this.employeesToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.employeesToolStripMenuItem1.Text = "Users";
            this.employeesToolStripMenuItem1.Click += new System.EventHandler(this.employeesToolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.usersToolStripMenuItem.Text = "Roles";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(555, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(132, 20);
            this.lblCurrentUser.TabIndex = 5;
            this.lblCurrentUser.Text = "lblCurrentUser";
            this.lblCurrentUser.Click += new System.EventHandler(this.lblCurrentUser_Click);
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterPage";
            this.Text = "Rent Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MasterPage_Load);
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
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carInspectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tpsSecurity;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem inspectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentAndDevolutionToolStripMenuItem;
    }
}

