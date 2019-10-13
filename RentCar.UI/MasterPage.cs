using RentCar.UI.Maintenances;
using System;
using System.Windows.Forms;

namespace RentCar.UI
{
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetActualForm<TForm>() where TForm : Form
        {
     
             var  form = Program.Container.GetInstance<TForm>();
            form.MdiParent = this;
            ShowActualForm(form);

        }

        private void ShowActualForm(Form form)
        {
            form.Show();
        }

        private void carBrandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmCarBrand>();
        }

        private void carCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmCarCategory>();
        }


        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmCar>();
        }

        private void fluelCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmFluelCategory>();
        }

        private void carModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmCarModel>();
        }

        private void personTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmPersonType>();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmEmployee>();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmClient>();
        }

        private void carInspectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmCarInspection>();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActualForm<FrmRentDevolution>();
        }

    }
}
