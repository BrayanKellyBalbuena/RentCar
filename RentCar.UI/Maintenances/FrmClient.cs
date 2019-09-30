using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmClient : Form
    {
        private readonly IEntityService<Client> clientService;
        private readonly IEntityService<PersonType> personTypeService;
        private bool isNew;
        private bool isEdit;

        public FrmClient(IEntityService<Client> clientService, IEntityService<PersonType> personTypeService)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);


            this.clientService = clientService;
            this.personTypeService = personTypeService;
        }

        private void FrmClients_Load(object sender, EventArgs e)
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
            cbPersonType.Enabled = valor;
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
                var data = await clientService.GetAll().ToListAsync();
                dgvClients.DataSource = Program.mapper.Map<IEnumerable<ClientViewModel>>(await clientService.GetAll().ToListAsync());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvClients.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }


            HideColumns();
        }

        private async void SetupComboBoxes()
        {
            cbPersonType.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbPersonType.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbPersonTypeSearch.ValueMember = DataGridColumnNames.ID_COLUMN;
            cbPersonTypeSearch.DisplayMember = DataGridColumnNames.NAME_COLUMN;

            cbPersonType.DataSource = await (from brand in personTypeService.GetAll()
                                           select new { Id = brand.Id, Name = brand.Name }
                                    ).ToListAsync();

            cbPersonTypeSearch.DataSource = cbPersonType.DataSource;
        }

        private void HideColumns()
        {
            dgvClients.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvClients.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
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
            dgvClients.DataSource = Program.mapper.Map<IEnumerable<CarModelViewModel>>(
               await clientService.GetAll(x => x.Name.Contains(txtSearch.Text) && x.PersonTypeId == (int)cbPersonTypeSearch.SelectedValue).ToListAsync()
                );
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvClients.Rows.Count;
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

                        await clientService.AddAsync(
                            new Client
                            {
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = DateTime.Now,
                                CarBrandId = (int)cbPersonType.SelectedValue

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await clientService.GetByIdAsync(int.Parse(txtIdCarModel.Text));

                        var model = new ClientViewModel
                        {
                            Id = int.Parse(txtIdCarModel.Text),
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            CarBrandId = entity.CarBrandId,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = Program.mapper.Map(model, entity);


                        await clientService.UpdateAsync(entity);

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

        private void dgvClients_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCarModel.Text = dgvClients.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            cbPersonType.SelectedValue = dgvClients.CurrentRow.Cells[DataGridColumnNames.CAR_BRAND_ID].Value;
            txtName.Text = dgvClients.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            txtDescription.Text = dgvClients.CurrentRow.Cells[DataGridColumnNames.DESCRIPCION_COLUMN].Value.ToString();
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
                dgvClients.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvClients.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClients.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvClients.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvClients.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await clientService.DeleteAsync(id);
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
