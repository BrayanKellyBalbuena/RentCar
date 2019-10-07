using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCar : Form
    {
        private IEntityService<Car> carService;
        private bool isNew;
        private bool isEdit;

        public FrmCar(IEntityService<Car> carService)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.carService = carService;
        }


        private void FrmCar_Load(object sender, EventArgs e)
        {
            EnableTextBox(false);
            EnableComboBox(false);
            EnableBottons();
            LoadEmployees();
            Show();
        }

        private void EnableTextBox(bool value)
        {
            txtName.ReadOnly = !value;
            txtChassisNumber.ReadOnly = !value;
            txtEngineNumber.ReadOnly = !value;
            txtPlacaNumber.ReadOnly = !value;
            txtIdEmployee.Enabled = false;
        }

        private void EnableComboBox(bool value)
        {
            cbBrand.Enabled = value;
            cbCarCategory.Enabled = value;
            cbCarModel.Enabled = value;
            cbFluelCategory.Enabled = value;
        }

        private void EnableBottons()
        {
            if (isNew || isEdit)
            {
                EnableTextBox(true);
                EnableComboBox(true);

                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                EnableTextBox(false);
                EnableComboBox(false);

                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private  void LoadEmployees()
        {
            try
            {
                dgvEmployees.DataSource = Program.mapper.Map<IEnumerable<CarViewModel>>(carService.GetAll().ToList());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvEmployees.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }

            HideColumns();
        }

        private void HideColumns()
        {
            dgvEmployees.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvEmployees.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
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
            txtIdentificationCard.Text = string.Empty;
            txtIdEmployee.Text = string.Empty;
        }

        private async void Search()
        {

            if (cbSearchType.SelectedIndex == 0)
            {
                dgvEmployees.DataSource = Program.mapper.Map<IEnumerable<CarViewModel>>(
                    await carService.GetAll(x => x.Name.Contains(txtSearch.Text)).ToListAsync()
                );
            }
            else
            {
                dgvEmployees.DataSource = Program.mapper.Map<IEnumerable<CarCategoryViewModel>>(
                    await carService.GetAll(x => x.IdentificationCard.Contains(txtSearch.Text)).ToListAsync()
               );
            }

            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvEmployees.Rows.Count;

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
            EnableComboBox(true);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTextBox())
                {
                    return;
                }
                else
                {
                    if (isNew)
                    {

                        await carService.AddAsync(
                            new Employee
                            {
                                Name = txtName.Text,
                                IdentificationCard = txtIdentificationCard.Text,
                                CreatedDate = DateTime.Now

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await carService.GetByIdAsync(int.Parse(txtIdEmployee.Text));

                        var employeeVm = new EmployeeViewModel
                        {
                            Id = int.Parse(txtIdEmployee.Text),
                            Name = txtName.Text,
                            IdentificationCard = txtIdentificationCard.Text,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = Program.mapper.Map(employeeVm, entity);

                        await carService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }

                    isNew = false;
                    isEdit = false;

                    EnableBottons();
                    ClearTextBox();
                    LoadEmployees();
                    ClearErrorProvider();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void ClearErrorProvider()
        {
            errorIcon.SetError(txtName, string.Empty);
            errorIcon.SetError(txtIdentificationCard, string.Empty);
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployees.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvEmployees.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        private void dgvEmployees_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmployee.Text = dgvEmployees.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            txtName.Text = dgvEmployees.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            txtIdentificationCard.Text = dgvEmployees.CurrentRow.Cells[DataGridColumnNames.IDENTIFICATION_CARD].Value.ToString();
            tabControl1.SelectedTab = tbpMantenance;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;

            EnableTextBox(false);
            EnableComboBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdEmployee.Text != string.Empty)
            {
                isEdit = true;
                EnableBottons();
                EnableTextBox(true);
                EnableComboBox(true);
            }
            else
            {
                MessageBoxUtil.MessageError(this, AlertMessages.NOT_RECORD_SELECTED_FOR_MODIFIY);
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
                dgvEmployees.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvEmployees.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (!chkDelete.Checked)
                {
                    MessageBoxUtil.MessageError(this, AlertMessages.NOT_RECORD_SELECTED_FOR_DELETE);
                    return;
                }

                DialogResult Opcion;
                Opcion = MessageBox.Show(AlertMessages.CONFIRM_DELETION, Constanst.SYSTEM_NAME,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvEmployees.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await carService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ////var frm = new FrmReportCarBrands();
            //frm.SeachText = txtSearch.Text;
            //frm.ShowDialog();
        }

        private void txtIdentificationCard_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).IsValidIdentificationCard();
        }

        private bool ValidateTextBox()
        {
            bool error = true;

            if (txtName.IsNotNullOrEmpty())
            {
                MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);
                errorIcon.SetError(txtName, AlertMessages.ENTER_A_NAME);
                error = false;
            }
            if (!txtIdentificationCard.IsValidIdentificationCard())
            {
                MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);
                errorIcon.SetError(txtIdentificationCard, AlertMessages.ENTER_A_VALID_IDENTIFICATION_CARD);
                error = false;
            }

            return error;
        }
    }
}
