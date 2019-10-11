using AutoMapper;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Extensions;
using RentCar.UI.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentCar.UI.FrmQueries
{
    public partial class FrmCarQuery : Form
    {
        private readonly IEntityService<Car> carService;
        private readonly IEntityService<CarBrand> carBrandService;
        private readonly IEntityService<CarModel> carModelService;
        private readonly IMapper mapper;

        public FrmCarQuery(IEntityService<Car> carService, IEntityService<CarBrand> carBrandService,
            IEntityService<CarModel> carModelService, IMapper mapper)
        {
            InitializeComponent();

            this.carService = carService;
            this.carBrandService = carBrandService;
            this.carModelService = carModelService;
            this.mapper = mapper;

        }

        private void FrmCarQuery_Load(object sender, EventArgs e)
        {
            LoadCars();
            SetupComboxes();
            LoadComboxes();
            HideColumns();
        }

        private void LoadCars()
        {
            dgvCars.DataSource = carService.GetAll().Take(100).ToList();
        }

        private void LoadComboxes()
        {
            cbBrandFilter.DataSource = carBrandService.GetAll().ToList();
            cbCarModelFilter.DataSource = carModelService.GetAll().ToList();
        }

        private void SetupComboxes()
        {
            cbBrandFilter.SetupMembers();
            cbCarModelFilter.SetupMembers();
        }

        private void HideColumns()
        {

            dgvCars.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_BRAND_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_MODEL_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.FLUEL_CATEGORY_ID].Visible = false;
            dgvCars.Columns[DataGridColumnNames.CAR_CATEGORY_ID].Visible = false;
        }

        private void dgvCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currenRow = dgvCars.CurrentRow;
            var parentForm = Parent;
          
            Hide();
        }
    }
}
