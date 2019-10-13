
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
using System.Collections.Generic;
using static RentCar.Infrastructure.utils.EncriptorUtil;
using RentCar.UI.FrmQueries;

namespace RentCar.UI.Maintenances
{
    public partial class FrmUser : Form
    {
        private readonly IEntityService<User> userService;
        private readonly IEntityService<Role> roleService;
        private readonly IMapper mapper;
        private bool isNew;
        private bool isEdit;
        private HashSet<UserRole> userRoles = new HashSet<UserRole>();
        private EmployeeViewModel selectedEmployee;

        public FrmUser(IEntityService<User> userService, IMapper mapper,
            IEntityService<Role> roleService)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.userService = userService;
            this.roleService = roleService;
            this.mapper = mapper;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            EnableTextBox(false);
            EnableBottons();
            FillRoleListView();
            LoadRoles();
            Show();
        }

        private void EnableTextBox(bool valor)
        {
            btnSelectEmployee.Enabled = valor;
            lvAvailableRole.Enabled = valor;
            //lvYourRole.Enabled = valor;
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

        private void FillRoleListView()
        {

            roleService.GetAll().ProjectTo<RoleViewModel>(mapper.ConfigurationProvider).ToList()
                .ForEach(r => lvAvailableRole.Items.Add(new ListViewItem() { Text = r.Name, Tag = r.Id }));
        }

        private void LoadRoles()
        {
            try
            {
                dgvUsers.DataSource = userService.GetAll()
                    .ProjectTo<UserViewModel>(mapper.ConfigurationProvider).ToList();

                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvUsers.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }


            HideColumns();
        }

        private void HideColumns()
        {
            dgvUsers.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvUsers.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
            dgvUsers.Columns[DataGridColumnNames.EMPLOYEE_ID].Visible = false;
            dgvUsers.Columns[DataGridColumnNames.USER_ROLES].Visible = false;

        }


        private void ClearTextBox()
        {
            //lvYourRole = new ListView();
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void Search()
        {
            dgvUsers.DataSource =
                userService.GetAll(x => x.UserName.Contains(txtSearch.Text))
                           .ProjectTo<UserViewModel>(mapper.ConfigurationProvider);

            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvUsers.Rows.Count;
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
                if (FormControlsHasError())
                {
                    return;
                }
                else
                {
                    if (isNew)
                    {

                        var user = new User
                        {
                            EmployeeId = selectedEmployee.Id,
                            UserName = txtName.Text,
                            UserPassword = ComputeSha256Hash(txtPassword.Text),
                            CreatedDate = DateTime.Now,
                            UserRoles = new HashSet<UserRole>()
                        };

                        foreach (var item in userRoles)
                        {
                            user.UserRoles.Add(item);
                        }

                        await userService.AddAsync(user);
                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await userService.GetByIdAsync(int.Parse(txtId.Text));
                        entity.Id = int.Parse(txtId.Text);
                        entity.EmployeeId = selectedEmployee.Id;
                        entity.UserPassword = ComputeSha256Hash(txtPassword.Text);
                        entity.UserName = txtName.Text;
                        entity.CreatedDate = entity.CreatedDate;

                        await userService.UpdateAsync(entity);

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

        private bool FormControlsHasError()
        {
            bool result = false;

            if(txtName.IsNotNullOrEmpty())
            {
                errorIcon.SetError(txtName, AlertMessages.ENTER_A_NAME);
                result = true;
            }

            if (txtPassword.IsNotNullOrEmpty())
            {
                errorIcon.SetError(txtPassword, AlertMessages.ENTER_PASSWORD);
                result = true;
            }
           

            if (lblYouRoles.Items.Count == 0)
            {
                errorIcon.SetError(lblYouRoles, AlertMessages.SELECT_ROLE);
                result = true;
            }

            if (selectedEmployee == null)
            {
                errorIcon.SetError(txtName, AlertMessages.SELECT_EMPLOYEE);
                result = true;
            }

            return result;
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = dgvUsers.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            txtName.Text = dgvUsers.CurrentRow.Cells[DataGridColumnNames.USER_NAME].Value.ToString();
            txtPassword.Text = dgvUsers.CurrentRow.Cells[DataGridColumnNames.PASSWORD].Value.ToString();
            var userRoles =(HashSet<UserRole>) dgvUsers.CurrentRow.Cells["UserRoles"].Value;

            foreach (var userRole in userRoles)
            {
                var item = new ListViewItem
                {
                    Text = userRole.Role.Name,
                    Tag = userRole.Role.Id,
                   
                };
                foreach (ListViewItem itemRemove in lvAvailableRole.Items)
                {
                    if ((int)item.Tag == (int)itemRemove.Tag)
                        lvAvailableRole.Items.Remove(itemRemove);
                }

                lblYouRoles.Items.Add(item);   
            }
          
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
                dgvUsers.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvUsers.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            }
        }

        private void dgvUsers_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvUsers.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
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
                    foreach (DataGridViewRow row in dgvUsers.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await userService.DeleteAsync(id);
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

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (lvAvailableRole.SelectedItems.Count == 0)
            {
                MessageBoxUtil.MessageError(this, "You must selec a role");
                return;
            }

            foreach (ListViewItem item in lvAvailableRole.SelectedItems)
            {
                userRoles.Add(new UserRole {RoleId = (int)item.Tag});

                lvAvailableRole.Items.Remove(item);

                lblYouRoles.Items.Add(item);
            }
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            if (lblYouRoles.SelectedItems.Count == 0)
            {
                MessageBoxUtil.MessageError(this, "You must selec a role");
                return;
            }

            foreach (ListViewItem item in lblYouRoles.SelectedItems)
            {
                userRoles.RemoveWhere(x => x.RoleId == (int)item.Tag);
                lblYouRoles.Items.Remove(item);
                lvAvailableRole.Items.Add(item);
            }
        }

        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
           var frmEmployeeQuery = Program.Container.GetInstance<FrmEmployeeQuery>();
            frmEmployeeQuery.EmployeeSelectedHandler += (s, ev) =>
            {
                selectedEmployee = ev.Data;
                txtName.Text = selectedEmployee.Name;
            };

            frmEmployeeQuery.ShowDialog();
        }
    }
}
