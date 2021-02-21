using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCityClient
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            UserServiceReference.User n_user = new UserServiceReference.User();

            n_user.UserID = userid_textBox.Text;
            n_user.Password = pass_textBox.Text;

            UserServiceReference.UserServiceClient proxy = new UserServiceReference.UserServiceClient("BasicHttpBinding_IUserService");

            proxy.AddUser(n_user);

            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
