using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.FrmQueries;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarInspection : Form
    {
        private readonly IEntityService<CarInspection> carInspectionService;
        private readonly IEntityService<Client> clientService;
        private readonly IEntityService<Car> carService;
        private readonly IMapper mapper;
        private CarViewModel selectedCart { get; set; }
        private ClientViewModel selectedClient { get; set; }
        private bool isNew;
        private bool isEdit;

        public FrmCarInspection(IEntityService<CarInspection> carInspectionService,
            IEntityService<Client> clientService, IEntityService<Car> carService,
            IMapper mapper)
        {
            InitializeComponent();

            this.carInspectionService = carInspectionService;
            this.clientService = clientService;
            this.carService = carService;
            this.mapper = mapper;
        }

        private void FrmCarInspection_Load(object sender, EventArgs e)
        {
            EnableBottons();
            LoadInspections();
            SetupComboBoxes();
            EnableFormControls(false);
            Show();
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            var frmSeachCar = Program.Container.GetInstance<FrmCarQuery>();

            frmSeachCar.CarSelectedHandler += (s, c) =>
            {
                selectedCart = mapper.Map<CarViewModel>(c.Car);
                txtCarName.Text = selectedCart.Name;
            };

            frmSeachCar.ShowDialog();
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            var frmClientQuery = Program.Container.GetInstance<FrmClientQuery>();

            frmClientQuery.ClientSelectedHandler += (s, ev) =>
            {
                selectedClient = ev.Data;
                txtClient.Text = selectedClient.Name;
            };

            frmClientQuery.ShowDialog();
        }

        private void EnableBottons()
        {
            if (isNew || isEdit)
            {
                this.EnableFormControls(true);
                btnNew.Enabled = false;
                btnSave.Enabled = true;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                this.EnableFormControls(false);
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private void LoadInspections()
        {
            try
            {

                dgvCartInspections.DataSource = carInspectionService.GetAll()
                    .ProjectTo<CarInspectionViewModel>(mapper.ConfigurationProvider)
                    .ToList();
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCartInspections.Rows.Count;

                HideColumns();
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }

        }

        private void SetupComboBoxes()
        {
            cbEmployee.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbEmployee.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbCars.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbCars.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbEmployee.DataSource = (from brand in clientService.GetAll()
                                     select new { brand.Id, brand.Name }
                                    ).ToList();

            cbCars.DataSource = (from car in carService.GetAll()
                                 select new { car.Id, car.Name }
                                 ).ToList();
        }

        private void HideColumns()
        {
            dgvCartInspections.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvCartInspections.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
            dgvCartInspections.Columns[DataGridColumnNames.EMPLOYEE_ID].Visible = false;
            dgvCartInspections.Columns[DataGridColumnNames.CLIENT_ID].Visible = false;
        }

        private void MessageOk(string message)
        {
            MessageBoxUtil.MessageOk(this, message);
        }

        private void MessageError(string message)
        {
            MessageBoxUtil.MessageError(this, message);
        }

        private void ResetFormControls()
        {
            txtCarName.Text = string.Empty;
            txtClient.Text = string.Empty;
            txtId.Text = string.Empty;
            chbHasReplacementTires.Checked = false;
            chbHasHydraulicJack.Checked = false;
            chbBrokenCrystal.Checked = false;
            chbFrontLeftTireState.Checked = false;
            chbBackLeftTireState.Checked = false;
            chbBackRightTireState.Checked = false;
            dtpInspectionDate.Value = DateTime.Now;
            nudFluelQuantity.Value = 0;
        }

        private  void Search()
        {
           dgvCartInspections.DataSource =carInspectionService
                .GetAll((c =>((c.InspectionsDate >= dtpFrom.Value && c.InspectionsDate <= dtpTo.Value)
                        && c.EmployeeId == (int) cbEmployee.SelectedValue
                        && c.ClientId == (int) cbCars.SelectedValue)
                        && c.State)
                        ).ProjectTo<CarInspectionViewModel>(mapper.ConfigurationProvider).ToList();
                    

            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvCartInspections.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            isEdit = false;

            btnSelectCar.Focus();
            EnableBottons();
            ResetFormControls();
            EnableFormControls(true);
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

                        await carInspectionService.AddAsync(
                            new CarInspection
                            {

                                CarId = selectedCart.Id,
                                ClientId = selectedClient.Id,
                                EmployeeId = 1,
                                FluelQuantity = (float)nudFluelQuantity.Value,
                                BackLeftTireState = chbBackLeftTireState.Checked,
                                BackRightTireState = chbBackRightTireState.Checked,
                                FrontLeftTireState = chbFrontLeftTireState.Checked,
                                FrontRightTireState = chbBrokenCrystal.Checked,
                                HasBrokenCrystal = chbBrokenCrystal.Checked,
                                HasReplacementTires = chbHasReplacementTires.Checked,
                                HasTires = chbHasTires.Checked,
                                HasHydraulicJack = chbHasHydraulicJack.Checked,
                                InspectionsDate = DateTime.Now

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await carInspectionService.GetByIdAsync(int.Parse(txtId.Text));
                        entity.CarId = selectedCart.Id;
                        entity.ClientId = selectedClient.Id;
                        entity.EmployeeId = 1;
                        entity.FluelQuantity = (float)nudFluelQuantity.Value;
                        entity.BackLeftTireState = chbBackLeftTireState.Checked;
                        entity.BackRightTireState = chbBackRightTireState.Checked;
                        entity.FrontLeftTireState = chbFrontLeftTireState.Checked;
                        entity.FrontRightTireState = chbBrokenCrystal.Checked;
                        entity.HasBrokenCrystal = chbBrokenCrystal.Checked;
                        entity.HasReplacementTires = chbHasReplacementTires.Checked;
                        entity.HasTires = chbHasTires.Checked;
                        entity.HasHydraulicJack = chbHasHydraulicJack.Checked;
                        entity.InspectionsDate = DateTime.Now;

                        await carInspectionService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    EnableBottons();
                    ResetFormControls();
                    LoadInspections();
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
            errorIcon.SetError(txtCarName, string.Empty);
            errorIcon.SetError(txtClient, string.Empty);
        }

        private async void dgvCartInspections_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvCartInspections.CurrentRow;
            txtId.Text = currentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            nudFluelQuantity.Value = Convert.ToDecimal(currentRow.Cells[DataGridColumnNames.FLUEL_QUANTITY].Value);
            chbBackLeftTireState.Checked = (bool) currentRow.Cells[DataGridColumnNames.BACK_LEFT_TIRESTATE].Value;
            chbBackRightTireState.Checked = (bool) currentRow.Cells[DataGridColumnNames.BACK_RIGHT_TIRE_STATE].Value;
            chbFrontLeftTireState.Checked = (bool) currentRow.Cells[DataGridColumnNames.FRONT_LEFT_TIRE_STATE].Value;
            chbBrokenCrystal.Checked = (bool) currentRow.Cells[DataGridColumnNames.HAS_BROKEN_CRYSTAL].Value;
            chbHasReplacementTires.Checked = (bool) currentRow.Cells[DataGridColumnNames.HAS_REPLACEMENT_TIRES].Value;
            chbHasTires.Checked = (bool) currentRow.Cells[DataGridColumnNames.HAS_TIRES].Value;
            chbHasHydraulicJack.Checked = (bool) currentRow.Cells[DataGridColumnNames.HAS_HYDRAULIC_JACK].Value;
            dtpInspectionDate.Value = (DateTime) currentRow.Cells[DataGridColumnNames.INSPECTIONS_DATE].Value;

            var car = await carService.GetByIdAsync((int)currentRow.Cells[DataGridColumnNames.CLIENT_ID].Value);
            selectedCart = mapper.Map<CarViewModel>(car);
            var client = await clientService.GetByIdAsync((int)currentRow.Cells[DataGridColumnNames.CLIENT_ID].Value);
            selectedClient = mapper.Map<ClientViewModel>(client);
            txtCarName.Text = selectedCart.Name;
            txtClient.Text = selectedClient.Name;

            tabControl1.SelectedTab = tbpMantenance;

            btnEdit.Enabled = true;
            btnNew.Enabled = false;

            EnableFormControls(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                isEdit = true;
                EnableBottons();
                EnableFormControls(true);
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
            EnableFormControls(false);
            this.ResetFormControls();
        }

        private void EnableFormControls(bool value)
        {
            chbBackLeftTireState.Enabled = value;
            chbBackRightTireState.Enabled = value;
            chbBrokenCrystal.Enabled = value;
            chbFrontLeftTireState.Enabled = value;
            chbFrontRightTireState.Enabled = value;
            chbHasHydraulicJack.Enabled = value;
            chbHasReplacementTires.Enabled = value;
            chbHasTires.Enabled = value;
            nudFluelQuantity.Enabled = value;
            btnSelectCar.Enabled = value;
            btnSelectClient.Enabled = value;
            dtpInspectionDate.Enabled = value;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                dgvCartInspections.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvCartInspections.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvCartInspections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCartInspections.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvCartInspections.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvCartInspections.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await carInspectionService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadInspections();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var frm = new FrmReportCarModel();
            ////frm.SeachText = txtSearch.Text;
            //frm.ShowDialog();
        }

        private bool ValidateTextBox()
        {
            bool error = true;

            if (selectedCart == null)
            {
                errorIcon.SetError(txtCarName, AlertMessages.ENTER_A_NAME);
                error = false;
            }

            if (selectedClient == null)
            {
                errorIcon.SetError(txtClient, AlertMessages.ENTER_A_NAME);
                error = false;
            }

            
            return error;
        }
    }
}
