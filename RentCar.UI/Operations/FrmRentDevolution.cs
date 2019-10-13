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
    public partial class FrmRentDevolution : Form
    {
        private readonly IEntityService<RentDevolution> rentDevolutionService;
        private readonly IEntityService<Client> clientService;
        private readonly IEntityService<Car> carService;
        private readonly IEntityService<Employee> employeeService;
        private readonly IMapper mapper;
        private CarViewModel selectedCart { get; set; }
        private ClientViewModel selectedClient { get; set; }
        private bool isNew;
        private bool isEdit;
        private const int FIRTS_OPTION = 0;

        public FrmRentDevolution(IEntityService<RentDevolution> rentDevolutionService,
            IEntityService<Client> clientService, IEntityService<Car> carService,
            IEntityService<Employee> employeeService, IMapper mapper)
        {
            InitializeComponent();

            this.rentDevolutionService = rentDevolutionService;
            this.clientService = clientService;
            this.carService = carService;
            this.employeeService = employeeService;
            this.mapper = mapper;
        }

        private void FrmRentDevolution_Load(object sender, EventArgs e)
        {
            EnableBottons();
            LoadRentDevolution();
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

        private void LoadRentDevolution()
        {
            try
            {
                dgvRentDevolutions.DataSource = rentDevolutionService.GetAll()
                    .ProjectTo<RentDevolutionViewModel>(mapper.ConfigurationProvider)
                    .ToList();

                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvRentDevolutions.Rows.Count;

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

            var employees = (from employee in employeeService.GetAll()
                                     select new { employee.Id, employee.Name }
                                    ).ToList();

            var AllOption = new { Id = 0, Name = "All" };

            employees.Insert(0, AllOption);

            cbEmployee.DataSource = employees;

            var cars = (from car in carService.GetAll()
                                 select new { car.Id, car.Name }
                       ).ToList();

            cars.Insert(0, AllOption);

            cbCars.DataSource = cars;
        }

        private void HideColumns()
        {
            dgvRentDevolutions.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvRentDevolutions.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
            dgvRentDevolutions.Columns[DataGridColumnNames.EMPLOYEE_ID].Visible = false;
            dgvRentDevolutions.Columns[DataGridColumnNames.CLIENT_ID].Visible = false;
            dgvRentDevolutions.Columns[DataGridColumnNames.CAR_ID].Visible = false;
        }

        private void ResetFormControls()
        {
            txtCarName.Text = string.Empty;
            txtClient.Text = string.Empty;
            txtId.Text = string.Empty;
            dtpRentDate.Value = DateTime.Now;
            nudAmount.Value = 0;
            txtComentary.Text = string.Empty;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var query = rentDevolutionService.GetAll();

            if (cbCars.SelectedIndex != FIRTS_OPTION)
            {
                query = query.Where(r => r.CarId == (int)cbCars.SelectedValue);
            }

            if(cbEmployee.SelectedIndex != FIRTS_OPTION)
            {
                query = query.Where(e => e.EmployeeId == (int)cbEmployee.SelectedValue);
            }

           query = query.Where(r => r.RentDate >= dtpFrom.Value && r.RentDate <= dtpTo.Value);

            dgvRentDevolutions.DataSource = query.ProjectTo<RentDevolutionViewModel>(mapper.ConfigurationProvider).ToList();

            dgvRentDevolutions.Refresh();
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvRentDevolutions.Rows.Count;
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
                        await rentDevolutionService.AddAsync(
                            new RentDevolution
                            {
                                CarId = selectedCart.Id,
                                ClientId = selectedClient.Id,
                                EmployeeId = 1,
                                RentDate = dtpRentDate.Value,
                                DevolutionDate = dtpDevolutionDate.Value,
                                DayQuantity = dtpDevolutionDate.Value.Subtract(dtpRentDate.Value).Days,
                                Comentary = txtComentary.Text,
                                AmountPerDay = nudAmount.Value,
                                CreatedBy = Program.CurrentUser.UserName
                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var rentDevolution = await rentDevolutionService.GetByIdAsync(int.Parse(txtId.Text));
                        rentDevolution.CarId = selectedCart.Id;
                        rentDevolution.ClientId = selectedClient.Id;
                        rentDevolution.EmployeeId = 1;
                        rentDevolution.RentDate = dtpRentDate.Value;
                        rentDevolution.DevolutionDate = dtpDevolutionDate.Value;
                        rentDevolution.DayQuantity = dtpDevolutionDate.Value.Subtract(dtpRentDate.Value).Days;
                        rentDevolution.Comentary = txtComentary.Text;
                        rentDevolution.AmountPerDay = nudAmount.Value;
                        rentDevolution.CreatedBy = Program.CurrentUser.UserName;

                        await rentDevolutionService.UpdateAsync(rentDevolution);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    EnableBottons();
                    ResetFormControls();
                    LoadRentDevolution();
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

        private async void dgvRentDevolution_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dgvRentDevolutions.CurrentRow;
            txtId.Text = currentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            nudAmount.Value = Convert.ToDecimal(currentRow.Cells[DataGridColumnNames.AMOUNT].Value);
            dtpRentDate.Value = (DateTime)currentRow.Cells[DataGridColumnNames.RENT_DATE].Value;
            dtpDevolutionDate.Value = (DateTime)currentRow.Cells[DataGridColumnNames.DEVOLUTION_DATE].Value;
            var car = await carService.GetByIdAsync((int)currentRow.Cells[DataGridColumnNames.CAR_ID].Value);
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
            ResetFormControls();
        }

        private void EnableFormControls(bool value)
        {
            dtpRentDate.Enabled = value;
            dtpDevolutionDate.Enabled = value;
            nudAmount.Enabled = value;
            btnSelectCar.Enabled = value;
            btnSelectClient.Enabled = value;
            dtpRentDate.Enabled = value;
            txtComentary.Enabled = value;
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                dgvRentDevolutions.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvRentDevolutions.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvRentDevolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRentDevolutions.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvRentDevolutions.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvRentDevolutions.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await rentDevolutionService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadRentDevolution();

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
                errorIcon.SetError(txtCarName, AlertMessages.SELECT_CAR);
                error = false;
            }

            if (selectedClient == null)
            {
                errorIcon.SetError(txtClient, AlertMessages.SELECT_CLIENT);
                error = false;
            }


            return error;
        }
    }
}
