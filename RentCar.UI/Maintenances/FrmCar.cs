using AutoMapper;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AutoMapper.QueryableExtensions;
using RentCar.UI.ViewModels;
using RentCar.UI.Extensions;
using System.Text.RegularExpressions;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCar : Form
    {
        private IEntityService<Car> carService;
        private IEntityService<CarBrand> carBrandService;
        private IEntityService<CarCategory> carCategoryService;
        private IEntityService<CarModel> carModelService;
        private IEntityService<FluelCategory> fluelCategorService;
        private IMapper mapper;
        private bool isNew;
        private bool isEdit;

        public FrmCar(IEntityService<Car> carService, IEntityService<CarBrand> carBrandService,
            IEntityService<CarCategory> carCategoryService, IEntityService<CarModel> carModelService,
            IEntityService<FluelCategory> fluelCategorService, IMapper mapper)
        {
            InitializeComponent();

            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.carService = carService;
            this.carBrandService = carBrandService;
            this.carCategoryService = carCategoryService;
            this.carModelService = carModelService;
            this.fluelCategorService = fluelCategorService;
            this.mapper = mapper;
        }


        private void FrmCar_Load(object sender, EventArgs e)
        {
            EnableTextBox(false);
            EnableComboBox(false);
            EnableBottons();
            SetupCombox();
            LoadEmployees();
            LoadComboBox();
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

        private void LoadEmployees()
        {
            try
            {
                dgvCars.DataSource = mapper.Map<IEnumerable<CarViewModel>>(carService.GetAll().ToList());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCars.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }

            HideColumns();
        }

        private void LoadComboBox()
        {
            cbBrand.DataSource = carBrandService.GetAll()
                .ProjectTo<CarBrandViewModelForComboBox>(mapper.ConfigurationProvider).ToList();
            cbCarModel.DataSource = carModelService.GetAll()
                .ProjectTo<CarModelViewModelForComboBox>(mapper.ConfigurationProvider).ToList();
            cbCarCategory.DataSource = carCategoryService.GetAll()
                .ProjectTo<CarCategoryViewModelForComboBox>(mapper.ConfigurationProvider).ToList();
            cbFluelCategory.DataSource = fluelCategorService.GetAll()
                .ProjectTo<FluelCategoryViewModelForComboBox>(mapper.ConfigurationProvider).ToList();

            cbBrandFilter.DataSource = cbBrand.DataSource;
            cbCategoryFilter.DataSource = cbCarCategory.DataSource;
            cbCarModelFilter.DataSource = cbCarModel.DataSource;
            cbFluelCategoryFilter.DataSource = cbFluelCategory.DataSource;
        }

        private void SetupCombox()
        {
            cbBrand.SetupMembers();
            cbCarCategory.SetupMembers();
            cbCarModel.SetupMembers();
            cbFluelCategory.SetupMembers();
            cbBrandFilter.SetupMembers();
            cbCategoryFilter.SetupMembers();
            cbCarModelFilter.SetupMembers();
            cbFluelCategoryFilter.SetupMembers();
        }

        private void HideColumns()
        {
            dgvCars.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvCars.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_BRAND_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_MODEL_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.FLUEL_CATEGORY_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_CATEGORY_ID].Visible = false;
        }

        private void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtIdEmployee.Text = string.Empty;
        }

        private async void Search()
        {

            var query = carService.GetAll(c => c.CarBrandId == (int) cbBrandFilter.SelectedValue
                && c.CarModelId == (int) cbCarModelFilter.SelectedValue
            );


            if (cbBrandFilter.SelectedIndex == 0)
            {
                dgvCars.DataSource = mapper.Map<IEnumerable<CarViewModel>>(
                    await carService.GetAll(x => x.Name.Contains(txtSearch.Text)).ToListAsync()
                );
            }
            else
            {


            }

            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCars.Rows.Count;

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
                            new Car
                            {
                                Name = txtName.Text,
                                ChassisNumber = txtChassisNumber.Text,
                                EngineNumber = txtEngineNumber.Text,
                                PlacaNumber = txtPlacaNumber.Text,
                                CarBrandId = (int)cbBrand.SelectedValue,
                                CarCategoryId = (int)cbCarCategory.SelectedValue,
                                CarModelId = (int)cbCarModel.SelectedValue,
                                FluelCategoryId = (int) cbFluelCategory.SelectedValue
                            }); ; 

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await carService.GetByIdAsync(int.Parse(txtIdEmployee.Text));

                        entity.Name = txtName.Text;
                        entity.ChassisNumber = txtChassisNumber.Text;
                        entity.EngineNumber = txtEngineNumber.Text;
                        entity.PlacaNumber = txtPlacaNumber.Text;
                        entity.CarBrandId = (int)cbBrand.SelectedValue;
                        entity.CarCategoryId = (int)cbCarCategory.SelectedValue;
                        entity.CarModelId = (int)cbCarModel.SelectedValue;
                        entity.FluelCategoryId = (int)cbFluelCategory.SelectedValue;

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
            errorIcon.Clear();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCars.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvCars.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        private void dgvCars_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEmployee.Text = dgvCars.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            txtName.Text = dgvCars.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            txtChassisNumber.Text = dgvCars.CurrentRow.Cells[DataGridColumnNames.CHASISS_NUMBER].Value.ToString();
            txtPlacaNumber.Text = dgvCars.CurrentRow.Cells[DataGridColumnNames.PLACA_NUMBER].Value.ToString();
            txtEngineNumber.Text = dgvCars.CurrentRow.Cells[DataGridColumnNames.ENGINE_NUMBER].Value.ToString();
            cbBrand.SelectedValue = dgvCars.CurrentRow.Cells[DataGridColumnNames.CAR_BRAND_ID].Value;
            cbCarCategory.SelectedValue = dgvCars.CurrentRow.Cells[DataGridColumnNames.CAR_CATEGORY_ID].Value;
            cbCarModel.SelectedValue = dgvCars.CurrentRow.Cells[DataGridColumnNames.CAR_MODEL_ID].Value;
            cbFluelCategory.SelectedValue = dgvCars.CurrentRow.Cells[DataGridColumnNames.FLUEL_CATEGORY_ID].Value;

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
            ClearTextBox();
            ClearErrorProvider();
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                dgvCars.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvCars.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
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
                    foreach (DataGridViewRow row in dgvCars.Rows)
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
                setMissingDataError(txtName);

                error = false;
            }

            if (txtPlacaNumber.IsNotNullOrEmpty())
            {
                setMissingDataError(txtPlacaNumber);
                error = false;
            }

            if (txtEngineNumber.IsNotNullOrEmpty() )
            {
                setMissingDataError(txtEngineNumber);

                error = false;
            }

            if (txtChassisNumber.IsNotNullOrEmpty())
            {
                setMissingDataError(txtChassisNumber);
            }

            if (!error) MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);

            return error;
        }

        private void setMissingDataError(TextBox textBox)
        {
            errorIcon.SetError(textBox, AlertMessages.MISSING_DATA);
        }

        private void txtPlacaNumber_TextChanged(object sender, EventArgs e)
        {
           (sender as TextBox).isValidPlacaNumber();
        }

        private void txtChassisNumber_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).isValidChassisNumber();
        }

        private void cbBrandFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCarModelFilter.DataSource = carModelService
                .GetAll(m => m.CarBrandId == (int) cbBrand.SelectedValue)
                .ToList();

            cbCarModelFilter.Refresh();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCarModel.DataSource = carModelService
               .GetAll(m => m.CarBrandId == (int)cbBrand.SelectedValue)
               .ToList();

            cbCarModel.Refresh();
        }
    }
}
