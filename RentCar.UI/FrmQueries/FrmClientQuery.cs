using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Abstractions;
using RentCar.UI.Constans;
using RentCar.UI.EventsArgs;
using RentCar.UI.Extensions;
using RentCar.UI.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;
namespace RentCar.UI.FrmQueries
{
    public partial class FrmClientQuery : Form
    {
        private readonly IEntityService<Client> clientService;
        private readonly IMapper mapper;
        public event EventHandler<EventArgs<ClientViewModel>> ClientSelectedHandler;

        public FrmClientQuery(IEntityService<Client> clientService, IMapper mapper)
        {
            InitializeComponent();

            this.clientService = clientService;
            this.mapper = mapper;

        }

        private void FrmClientQuery_Load(object sender, EventArgs e)
        {
            LoadCars();
            HideColumns();
        }

        private void LoadCars()
        {
            dgvClients.DataSource = clientService.GetAll().Take(100).ToList();
        }

        private void HideColumns()
        {
            dgvClients.Columns[DataGridColumnNames.ID_COLUMN].Visible = false;
        }

        private void dgvCars_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var currenRow = dgvClients.CurrentRow;

            ClientSelectedHandler?.Invoke(this, new EventArgs<ClientViewModel>
            {
                Data = new ClientViewModel 
                {
                    Id = (int) currenRow.Cells[DataGridColumnNames.ID_COLUMN].Value,
                    Name = currenRow.Cells[DataGridColumnNames.NAME_COLUMN].Value.ToString()
                }
            });

            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = clientService.GetAll().ProjectTo<ClientViewModel>(mapper.ConfigurationProvider);

            if (cbFilter.SelectedIndex == 1)
                query = query.Where(c => c.Name.Contains(txtFilter.Text.ToString()));

            if (cbFilter.SelectedIndex == 2)
                query = query.Where(c => c.IdentificationCard.Contains(txtFilter.Text.ToString()));

            dgvClients.DataSource = query.ToList();
            dgvClients.Refresh();
        }
    }
}
