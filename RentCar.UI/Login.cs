using RentCar.Core.Entities;
using RentCar.Core.Interfaces.Domain;
using RentCar.Infrastructure.DbContexts;
using RentCar.Infrastructure.Services;
using RentCar.UI.Constans;
using RentCar.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RentCar.Infrastructure.utils.EncriptorUtil;

namespace RentCar.UI
{
    public partial class Login : Form
    {
        private readonly IEntityService<User> userService;

        public Login(IEntityService<User> userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (TextBoxAreValids())
            {
                var passwordHash = ComputeSha256Hash(txtPassword.Text);
                var user = userService.GetAll()
                    .Where(u => u.UserName == txtUserName.Text
                        && u.UserPassword == passwordHash).FirstOrDefault();

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
