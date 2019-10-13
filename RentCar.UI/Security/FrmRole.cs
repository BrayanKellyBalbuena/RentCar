
using AutoMapper;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using System;
using System.Windows.Forms;
using AutoMapper.QueryableExtensions;
using System.Linq;
using RentCar.UI.ViewModels;

namespace RentCar.UI.Maintenances
{
    public partial class FrmRole : Form
    {
        private readonly IEntityService<Role> roleService;
        private readonly IMapper mapper;
        private bool isNew;
        private bool isEdit;

        public FrmRole(IEntityService<Role> roleService, IMapper mapper)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.roleService = roleService;
            this.mapper = mapper;
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {

            EnableTextBox(false);
            EnableBottons();
            LoadRoles();
            Show();

        }

        private void EnableTextBox(bool valor)
        {
            txtName.ReadOnly = !valor;
            txtId.Enabled = false;
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

        private void LoadRoles()
        {
            try
            {
                dgvRoles.DataSource = roleService.GetAll()
                    .ProjectTo<RoleViewModel>(mapper.ConfigurationProvider).ToList();

                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvRoles.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }


            HideColumns();
        }

        private void HideColumns()
        {
            dgvRoles.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvRoles.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
        }

        private void ClearTextBox()
        {
            txtName.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void Search()
        {
            dgvRoles.DataSource =
                roleService.GetAll(x => x.Name.Contains(txtSearch.Text))
                           .ProjectTo<RoleViewModel>(mapper.ConfigurationProvider);

            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvRoles.Rows.Count;
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

                        await roleService.AddAsync(
                            new Role
                            {
                                Name = txtName.Text,
                                CreatedDate = DateTime.Now,
                                CreatedBy = Program.CurrentUser.UserName

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await roleService.GetByIdAsync(int.Parse(txtId.Text));
                        entity.Id = int.Parse(txtId.Text);
                        entity.Name = txtName.Text;
                        entity.CreatedDate = entity.CreatedDate;
                        entity.CreatedBy = Program.CurrentUser.UserName;

                        await roleService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }
                    isNew = false;
                    isEdit = false;

                    EnableBottons();
                    ClearTextBox();
                    LoadRoles();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void dgvRoles_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvRoles.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            txtName.Text = dgvRoles.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            tabControl1.SelectedTab = tbpMantenance;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;

            EnableTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
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
            EnableTextBox(false);
            this.ClearTextBox();
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelete.Checked)
            {
                dgvRoles.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvRoles.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvRoles_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRoles.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvRoles.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvRoles.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await roleService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadRoles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var frm = new FrmReportRoles();
            //frm.SeachText = txtSearch.Text;
            //frm.ShowDialog();
        }
    }
}
