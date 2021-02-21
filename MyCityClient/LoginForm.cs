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
    public partial class LoginForm : Form
    {
        public static string userid = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userid = textBox1.Text;
            string pass = textBox2.Text;

            UserServiceReference.UserServiceClient proxy = new UserServiceReference.UserServiceClient("BasicHttpBinding_IUserService");

            UserServiceReference.User o_user = new UserServiceReference.User();

            o_user = proxy.GetUser(userid);

            if( o_user.Password == pass )
            {

                StoreForm sf = new StoreForm();
                sf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show( "Incorrect Password." );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }
    }
}
