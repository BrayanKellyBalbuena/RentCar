using RentCar.UI.FrmQueries;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarInspection : Form
    {
        private CarViewModelForComboBox selectedCart { get; set; }
        public FrmCarInspection()
        {
            InitializeComponent();
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            var frmSeachCar = Program.Container.GetInstance<FrmCarQuery>();

            frmSeachCar.CarSelected.Subscribe( 
                c =>  Debug.WriteLine(c.Name),
                err => { },
                () => { });
            frmSeachCar.Show();
        }
    }
}
