﻿
using AutoMapper;
using MetroFramework;
using MetroFramework.Forms;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Reports;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarBrand : Form
    {
        private IEntityService<CarBrand> carBrandService;
        private bool isNew;
        private bool isEdit;
        private string ENTER_NAME_MESSAGE = "Enter a name of Card Brands";
        private const string DELETE_COLUMN = "Delete";
        private const string ID_COLUMN = "Id";

        public FrmCarBrand(IEntityService<CarBrand> carBrandService) 
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, ENTER_NAME_MESSAGE);
            this.carBrandService = carBrandService;
        }

        //public static FrmCarBrand GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new FrmCarBrand();
        //    }
        //    if (instance.IsDisposed) {
        //        instance = new FrmCarBrand();
               
        //    }
        //    return instance;

        //}

        private void FrmCarBrands_Load(object sender, EventArgs e)
        {
      
            EnableTextBox(false);
            EnableBottons();
            LoadCarBrands();
            Show();

        }

        private void EnableTextBox(bool valor)
        {
            txtName.ReadOnly = !valor;
            txtDescription.ReadOnly = !valor;
            txtIdCarBrand.Enabled = false;
        }

        private void EnableBottons()
        {
            if (isNew || isEdit)
            {
                this.EnableTextBox(true);
                EnableTextBox(true);
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                this.EnableTextBox(false);
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private async void LoadCarBrands()
        {
            try {
                dgvCarBrands.DataSource =   Program.mapper.Map<IEnumerable<CarBrandViewModel>>( await carBrandService.GetAll().ToListAsync());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarBrands.Rows.Count;
            }
            catch (Exception ex)
            {

            }


            HideColumns();
        }

        private void HideColumns()
        {
            dgvCarBrands.Columns[DELETE_COLUMN].Visible = false;
            dgvCarBrands.Columns[ID_COLUMN].Visible = false;
        }


        private void MessageOk(string message)
        {
            MessageBoxUtil.MessageOk(this, message);
        }

        private void MessageError(string message)
        {
            MessageBoxUtil.MessageError(this, message);
        }

        private void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtIdCarBrand.Text = string.Empty;
        }

        private async void Search()
        {
            dgvCarBrands.DataSource = Program.mapper.Map<IEnumerable<CarBrandViewModel>>(
               await carBrandService.GetAll(x => x.Name.Contains(txtSearch.Text)).ToListAsync()
                );
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarBrands.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            isEdit = false;

            txtName.Focus();
            EnableBottons();
            ClearTextBox();
            EnableTextBox(true);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.IsNotNullOrEmpty())
                {
                    MessageBoxUtil.MessageError(this, "Falta ingresar algunos datos, serán remarcados");
                    errorIcon.SetError(txtName, "Ingrese un Nombre");
                }
                else
                {
                    if (isNew)
                    {

                        await carBrandService.AddAsync(
                            new CarBrand
                            {
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = DateTime.Now

                            });

                        MessageBoxUtil.MessageOk(this, "Se Insertó de forma correcta el registro");

                    }
                    else
                    {
                        var entity = await carBrandService.GetByIdAsync(int.Parse(txtIdCarBrand.Text));

                        var brand = new CarBrandViewModel
                        {
                            Id = int.Parse(txtIdCarBrand.Text),
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = Program.mapper.Map(brand, entity);

                   
                        await carBrandService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, "Se Actualizó de forma correcta el registro");
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    this.EnableBottons();
                    this.ClearTextBox();
                    this.LoadCarBrands();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void dgvCarBrands_DoubleClick(object sender, EventArgs e)
        {
            txtIdCarBrand.Text = dgvCarBrands.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dgvCarBrands.CurrentRow.Cells["Name"].Value.ToString();
            txtDescription.Text = dgvCarBrands.CurrentRow.Cells["Description"].Value.ToString();
            this.tabControl1.SelectedTab = tbpMantenance;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;
            EnableTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtIdCarBrand.Text != string.Empty)
            {
                isEdit = true;
                EnableBottons();
                EnableTextBox(true);
            } else
            {
                MessageBoxUtil.MessageError(this, "Debe Seleccionar primero el registro a modificar");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isNew = false;
            isEdit = false;
            EnableBottons();
            EnableTextBox(true);
            this.ClearTextBox();
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                dgvCarBrands.Columns[DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvCarBrands.Columns[DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvCarBrands_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarBrands.Columns[DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete =  dgvCarBrands.Rows[e.RowIndex].Cells[DELETE_COLUMN] as DataGridViewCheckBoxCell;
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvCarBrands.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                           int id = Convert.ToInt32(row.Cells[1].Value);

                            await carBrandService.DeleteAsync(id);
                                MessageBoxUtil.MessageOk(this,"Se Eliminó Correctamente el registro");
                            }

                        }
                    }
                    LoadCarBrands();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportCarBrands();
            frm.SeachText = txtSearch.Text;
            frm.ShowDialog();
        }
    }
}
