using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Reports;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarCategory : Form
    {
        private IEntityService<CarCategory> carCategoryService;
        private bool isNew;
        private bool isEdit;
        private string ENTER_NAME_MESSAGE = "Enter a name of Card Category";
        private const string DELETE_COLUMN = "Delete";
        private const string ID_COLUMN = "Id";

        public FrmCarCategory(IEntityService<CarCategory> carCategoryService)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, ENTER_NAME_MESSAGE);
            this.carCategoryService = carCategoryService;
        }


        private void FrmCarCategory_Load(object sender, EventArgs e)
        {
            EnableTextBox(false);
            EnableBottons();
            LoadCarCategory();
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

        private async void LoadCarCategory()
        {
            try
            {
                dgvCarCategory.DataSource = Program.mapper.Map<IEnumerable<CarCategoryViewModel>>(await carCategoryService.GetAll().ToListAsync());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarCategory.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageOk(this, ex.Message);
            }


            HideColumns();
        }

        private void HideColumns()
        {
            dgvCarCategory.Columns[DELETE_COLUMN].Visible = false;
            dgvCarCategory.Columns[ID_COLUMN].Visible = false;
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
            dgvCarCategory.DataSource = Program.mapper.Map<IEnumerable<CarBrandViewModel>>(
               await carCategoryService.GetAll(x => x.Name.Contains(txtSearch.Text)).ToListAsync()
                );
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarCategory.Rows.Count;
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

                        await carCategoryService.AddAsync(
                            new CarCategory
                            {
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = DateTime.Now

                            });

                        MessageBoxUtil.MessageOk(this, "Se Insertó de forma correcta el registro");

                    }
                    else
                    {
                        var entity = await carCategoryService.GetByIdAsync(int.Parse(txtIdCarBrand.Text));

                        var brand = new CarCategoryViewModel
                        {
                            Id = int.Parse(txtIdCarBrand.Text),
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = Program.mapper.Map(brand, entity);


                        await carCategoryService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, "Se Actualizó de forma correcta el registro");
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    this.EnableBottons();
                    this.ClearTextBox();
                    this.LoadCarCategory();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void dgvCarCategory_DoubleClick(object sender, EventArgs e)
        {
            txtIdCarBrand.Text = dgvCarCategory.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dgvCarCategory.CurrentRow.Cells["Name"].Value.ToString();
            txtDescription.Text = dgvCarCategory.CurrentRow.Cells["Description"].Value.ToString();
            this.tabControl1.SelectedTab = tbpMantenance;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;
            EnableTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdCarBrand.Text != string.Empty)
            {
                isEdit = true;
                EnableBottons();
                EnableTextBox(true);
            }
            else
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
                dgvCarCategory.Columns[DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvCarCategory.Columns[DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvCarCategory_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarCategory.Columns[DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvCarCategory.Rows[e.RowIndex].Cells[DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvCarCategory.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[1].Value);

                            await carCategoryService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, "Se Eliminó Correctamente el registro");
                        }

                    }
                }
                LoadCarCategory();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportCarCategory();
            frm.SearchText = txtSearch.Text;
            frm.ShowDialog();
        }
    }
}
