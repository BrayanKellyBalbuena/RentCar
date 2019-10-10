using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using RentCar.UI.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;
using AutoMapper;

namespace RentCar.UI.Maintenances
{
    public partial class FrmFluelCategory : Form
    {
        private readonly IEntityService<FluelCategory> fluelCategoryService;
        private readonly IMapper mapper;
        private bool isNew;
        private bool isEdit;

        public FrmFluelCategory(IEntityService<FluelCategory> fluelCategoryService, IMapper mapper)
        {
            InitializeComponent();
            ttMessage.SetToolTip(txtName, AlertMessages.ENTER_A_NAME);
            this.fluelCategoryService = fluelCategoryService;
            this.mapper = mapper;
        }


        private void FrmFluelCategory_Load(object sender, EventArgs e)
        {

            EnableTextBox(false);
            EnableBottons();
            LoadFluelCategories();
            Show();

        }

        private void EnableTextBox(bool valor)
        {
            txtName.ReadOnly = !valor;
            txtDescription.ReadOnly = !valor;
            txtIdFluelCategory.Enabled = false;
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
                EnableTextBox(false);
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private async void LoadFluelCategories()
        {
            try
            {
                dgvFluelCategories.DataSource = mapper.Map<IEnumerable<FluelCategoryViewModel>>(await fluelCategoryService.GetAll().ToListAsync());
                lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvFluelCategories.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }

            HideColumns();
        }

        private void HideColumns()
        {
            dgvFluelCategories.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
            dgvFluelCategories.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
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
            txtIdFluelCategory.Text = string.Empty;
        }

        private async void Search()
        {
            dgvFluelCategories.DataSource = mapper.Map<IEnumerable<FluelCategoryViewModel>>(
               await fluelCategoryService.GetAll(x => x.Name.Contains(txtSearch.Text)).ToListAsync()
                );
            lblTotalRows.Text = Constanst.TOTAL_REGISTERS + dgvFluelCategories.Rows.Count;
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

                        await fluelCategoryService.AddAsync(
                            new FluelCategory
                            {
                                Name = txtName.Text,
                                Description = txtDescription.Text,
                                CreatedDate = DateTime.Now

                            });

                        MessageBoxUtil.MessageOk(this, AlertMessages.INSERTED_SUCCESSFULLY);

                    }
                    else
                    {
                        var entity = await fluelCategoryService.GetByIdAsync(int.Parse(txtIdFluelCategory.Text));

                        var brand = new FluelCategoryViewModel
                        {
                            Id = int.Parse(txtIdFluelCategory.Text),
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            CreatedDate = entity.CreatedDate,
                            ModifiedDate = DateTime.Now
                        };
                        entity = mapper.Map(brand, entity);

                        await fluelCategoryService.UpdateAsync(entity);

                        MessageBoxUtil.MessageOk(this, AlertMessages.UPDATED_SUCCESSFULLY);
                    }
                    this.isNew = false;
                    this.isEdit = false;

                    this.EnableBottons();
                    this.ClearTextBox();
                    this.LoadFluelCategories();

                }
            }
            catch (Exception ex)
            {
                MessageBoxUtil.MessageError(this, ex.Message);
            }
        }

        private void dgvFluelCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFluelCategories.Columns[DataGridColumnNames.DELETE_COLUMN].Index)
            {
                DataGridViewCheckBoxCell chkDelete = dgvFluelCategories.Rows[e.RowIndex].Cells[DataGridColumnNames.DELETE_COLUMN] as DataGridViewCheckBoxCell;
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        private void dgvFluelCategories_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdFluelCategory.Text = dgvFluelCategories.CurrentRow.Cells[DataGridColumnNames.ID_COLUMN].Value.ToString();
            txtName.Text = dgvFluelCategories.CurrentRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString();
            txtDescription.Text = dgvFluelCategories.CurrentRow.Cells[DataGridColumnNames.DESCRIPCION_COLUMN].Value.ToString();
            this.tabControl1.SelectedTab = tbpMantenance;
            btnEdit.Enabled = true;
            btnNew.Enabled = false;
            EnableTextBox(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtIdFluelCategory.Text != string.Empty)
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
                dgvFluelCategories.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = true;
            }
            else
            {
                dgvFluelCategories.Columns[DataGridColumnNames.DELETE_COLUMN].Visible = false;
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
                    foreach (DataGridViewRow row in dgvFluelCategories.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[DataGridColumnNames.DELETE_COLUMN].Value))
                        {
                            int id = Convert.ToInt32(row.Cells[DataGridColumnNames.ID_COLUMN].Value);

                            await fluelCategoryService.DeleteAsync(id);
                            MessageBoxUtil.MessageOk(this, AlertMessages.DELETED_SUCCESSFULLY);
                        }

                    }
                }
                LoadFluelCategories();

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
    }
}
