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
        private void OpenForm<TForm>() where TForm : Form
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
            OpenForm<FrmCarBrand>();
        }

        private void carCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCarCategory>();
        }


        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCar>();
        }

        private void fluelCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmFluelCategory>();
        }

        private void carModelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCarModel>();
        }

        private void personTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmPersonType>();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmEmployee>();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmClient>();
        }

        private void carInspectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCarInspection>();
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRentDevolution>();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<FrmRole>();
        }
    }
}
