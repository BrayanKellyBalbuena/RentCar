using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Reports;
using RentCar.UI.Utils;
using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarModel : Form
    {
        private readonly IEntityService<CarModel> carModelService;
        private readonly IEntityService<CarBrand> carBrandService;
        private readonly IMapper mapper;
        private bool isNew;
        private bool isEdit;

        public FrmCarModel(IEntityService<CarModel> carModelService, IEntityService<CarBrand> carBrandService, IMapper mapper)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.carModelService = carModelService;
            this.carBrandService = carBrandService;
            this.mapper = mapper;
        }

        private void FrmCarModels_Load(object sender, EventArgs e)
        {

            EnableTextBox(false);
            EnableBottons();
            LoadCarModels();
            SetupComboBoxes();
            Show();

        }

        private void EnableTextBox(bool valor)
        {
            txtName.ReadOnly = !valor;
            txtDescription.ReadOnly = !valor;
            txtIdCarModel.Enabled = false;
            cbCarBrand.Enabled = valor;
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

        private async void LoadCarModels()
        {
            try
            {
                var data = await carModelService.GetAll().ToListAsync();
                dgvCarModels.DataSource = mapper.Map<IEnumerable<CarModelViewModel>>(await carModelService.GetAll().ToListAsync());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarModels.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }


            HideColumns();
        }

        private async void SetupComboBoxes()
        {
            cbCarBrand.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbCarBrand.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbBrandSearch.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbBrandSearch.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbCarBrand.DataSource = await (from brand in carBrandService.GetAll()
                                           select new { Id = brand.Id, Name = brand.Name }
                                    ).ToListAsync();

            cbBrandSearch.DataSource = cbCarBrand.DataSource;
        }

        private void HideColumns()
        {
            dgvCarModels.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvCarModels.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
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
            txtIdCarModel.Text = string.Empty;
        }

        private async void Search()
        {
            dgvCarModels.DataSource = mapper.Map<IEnumerable<CarModelViewModel>>(
               await carModelService.GetAll(x => x.Name.Contains(txtSearch.Text) && x.CarBrandId == (int) cbBrandSearch.SelectedValue).ToListAsync()
                );
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCarModels.Rows.Count;
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
                    MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);
                    errorIcon.SetError(txtName, AlertMessages.ENTER_A_NAME);
                }
                else
                {
                    if (isNew)
                    {

                        await carModelService.AddAsync(
                            new CarModel
                            {
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = DateTime.Now,
                                CarBrandId = (int) cbCarBrand.SelectedValue

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await carModelService.GetByIdAsync(int.Parse(txtIdCarModel.Text));

                        var Model = new CarModelViewModel
                        {
                            Id = int.Parse(txtIdCarModel.Text),
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            CarBrandId = entity.CarBrandId,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = mapper.Map(Model, entity);


                        await carModelService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    this.EnableBottons();
                    this.ClearTextBox();
                    this.LoadCarModels();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void dgvCarModels_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCarModel.Text = dgvCarModels.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            cbCarBrand.SelectedValue = dgvCarModels.CurrentRow.Cells[DataGridColumnNames.CAR_BRAND_ID].Value;
            txtName.Text = dgvCarModels.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            txtDescription.Text = dgvCarModels.CurrentRow.Cells[DataGridColumnNames.DESCRIPCION_COLUMN].Value.ToString();
            tabControl1.SelectedTab = tbpMantenance;

            btnEdit.Enabled = true;
            btnNew.Enabled = false;

            EnableTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdCarModel.Text != string.Empty)
            {
                isEdit = true;
                EnableBottons();
                EnableTextBox(true);
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
                dgvCarModels.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvCarModels.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvCarModels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarModels.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvCarModels.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
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
                    foreach (DataGridViewRow row in dgvCarModels.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await carModelService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadCarModels();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var frm = new FrmReportCarModel();
            //frm.SeachText = txtSearch.Text;
            frm.ShowDialog();
        }

    }
}
