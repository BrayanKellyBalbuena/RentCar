using AutoMapper;
using RentCar.UI.FrmQueries;
using RentCar.UI.ViewModels;
using System;
using System.Windows.Forms;

namespace RentCar.UI.Maintenances
{
    public partial class FrmCarInspection : Form
    {
        private CarViewModelForComboBox selectedCart { get; set; }
        private readonly IMapper mapper;

        public FrmCarInspection(IMapper mapper)
        {
            InitializeComponent();
            this.mapper = mapper;
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            var frmSeachCar = Program.Container.GetInstance<FrmCarQuery>();

            frmSeachCar.CarSelectedHandler += (s, c) => {
                selectedCart =  mapper.Map<CarViewModelForComboBox>(c.Car);
                txtCarName.Text = selectedCart.Name;
            };



            frmSeachCar.ShowDialog();
        }
    }
}
