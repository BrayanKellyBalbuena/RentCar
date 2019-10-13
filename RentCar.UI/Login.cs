using AutoMapper;
using AutoMapper.QueryableExtensions;
using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using RentCar.UI.ViewModels;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static RentCar.Infrastructure.utils.EncriptorUtil;

namespace RentCar.UI
{
    public partial class Login : Form
    {
        private readonly IEntityService<User> userService;
        private readonly IMapper mapper;

        public Login(IEntityService<User> userService, IMapper mapper)
        {
            InitializeComponent();
            this.userService = userService;
            this.mapper = mapper;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (TextBoxAreValids())
            {
                var passwordHash = ComputeSha256Hash(txtPassword.Text);
                var user = userService.GetAll()
                    .Where(u => u.UserName == txtUserName.Text
                        && u.UserPassword == passwordHash)
                    .ProjectTo<UserViewModel>(mapper.ConfigurationProvider)
                    .FirstOrDefault();


                if (user != null)
                {
                    Program.CurrentUser = user;
                    var masterPage = Program.Container.GetInstance<MasterPage>();
                    this.Hide();
                    masterPage.Show();
                }
                else
                {
                    MessageBoxUtil.MessageError(this, AlertMessages.INCORRECT_USER_PASSWORD);
                }

            }
           
        }

        private bool TextBoxAreValids()
        {
            bool result = true;

            if (txtPassword.IsNotNullOrEmpty())
            {
               MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);
                result = false;
            }

            if (txtPassword.IsNotNullOrEmpty())
            {
                MessageBoxUtil.MessageError(this, AlertMessages.MISSING_DATA);
                result = false;
            }

            return result;

        }
    }


}
