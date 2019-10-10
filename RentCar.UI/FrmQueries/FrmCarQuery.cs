using AutoMapper;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Extensions;
using RentCar.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.UI.FrmQueries
{
    public partial class FrmCarQuery : Form
    {
        private readonly IEntityService<Car> carService;
        private readonly IEntityService<CarBrand> carBrandService;
        private readonly IEntityService<CarModel> carModelService;
        private readonly IMapper mapper;
        public IObservable<CarViewModelForComboBox> CarSelected { get; private set; } = Observable.Return(
                new CarViewModelForComboBox());

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

        private async void dgvCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currenRow = dgvCars.CurrentRow;
            var parentForm = Parent;
            CarSelected =  Observable.Return(
                new CarViewModelForComboBox
                {
                    Id = (int)currenRow.Cells[DataGridColumnNames.ID_COLUMN].Value,
                    Name = currenRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString()
                });

            Hide();
        }
    }
}
