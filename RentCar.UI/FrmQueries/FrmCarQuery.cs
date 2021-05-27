using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.EventsArgs;
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
        public event EventHandler<CarSelectedEventArgs> CarSelectedHandler;

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
            var carBrands = carBrandService.GetAll()
                .ProjectTo<CarBrandViewModelForComboBox>(mapper.ConfigurationProvider).ToList();

            var carModels = carModelService.GetAll().
                ProjectTo<CarModelViewModelForComboBox>(mapper.ConfigurationProvider).ToList();

            carBrands.Insert(0, new CarBrandViewModelForComboBox { Id = 0, Name = "All" });
            carModels.Insert(0, new CarModelViewModelForComboBox { Id = 0, Name = "All" });

            cbBrandFilter.DataSource = carBrands;
            cbCarModelFilter.DataSource = carModels;
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

            CarSelectedHandler?.Invoke(this, new CarSelectedEventArgs
            {
                Car = new CarViewModel
                {
                    Id = (int)currenRow.Cells[DataGridColumnNames.ID_COLUMN].Value,
                    Name = currenRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString()
                }
            });

            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = carService.GetAll().ProjectTo<CarViewModel>(mapper.ConfigurationProvider);

            if ((( int) cbBrandFilter.SelectedValue) != 0) 
            {
                query = query.Where(c => c.CarBrandId == (int)cbBrandFilter.SelectedValue);
            }
            if (((int)cbCarModelFilter.SelectedValue) != 0)
            {
                query = query.Where(c => c.CarModelId == (int)cbCarModelFilter.SelectedValue);
            }
            if(!string.IsNullOrEmpty(txtFilter.Text))
            {
                query  = query.Where(c => c.Name.Contains(txtFilter.Text.ToString())
                    || c.PlacaNumber.Contains(txtFilter.Text.ToString()));
            }

            dgvCars.DataSource = query.ToList();
            dgvCars.Refresh();
        }

    }
}
