using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.EventsArgs;
using RentCar.UI.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
namespace RentCar.UI.FrmQueries
{
    public partial class FrmEmployeeQuery : Form
    {
        private readonly IEntityService<Employee> employeeService;
        private readonly IMapper mapper;
        public event EventHandler<EventArgs<EmployeeViewModel>> EmployeeSelectedHandler;

        public FrmEmployeeQuery(IEntityService<Employee> employeeService, IMapper mapper)
        {
            InitializeComponent();

            this.employeeService = employeeService;
            this.mapper = mapper;

        }

        private void FrmEmployeeQuery_Load(object sender, EventArgs e)
        {
            LoadCars();
            HideColumns();
        }

        private void LoadCars()
        {
            dgvClients.DataSource = employeeService.GetAll().Take(100).ToList();
        }

        private void HideColumns()
        {
            dgvClients.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
        }

        private void dgvCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currenRow = dgvClients.CurrentRow;

            EmployeeSelectedHandler?.Invoke(this, new EventArgs<EmployeeViewModel>
            {
                Data = new EmployeeViewModel
                {
                    Id = (int) currenRow.Cells[DataGridColumnNames.ID_COLUMN].Value,
                    Name = currenRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString()
                }
            });

            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = employeeService.GetAll().ProjectTo<EmployeeViewModel>(mapper.ConfigurationProvider);

            if (cbFilter.SelectedIndex == 1)
                query = query.Where(c => c.Name.Contains(txtFilter.Text.ToString()));

            if (cbFilter.SelectedIndex == 2)
                query = query.Where(c => c.IdentificationCard.Contains(txtFilter.Text.ToString()));

            dgvClients.DataSource = query.ToList();
            dgvClients.Refresh();
        }
    }
}
