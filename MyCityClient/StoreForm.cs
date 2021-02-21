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
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            welcome_label.Text += LoginForm.userid;

            StoreServiceReference.StoreServiceClient proxy = new StoreServiceReference.StoreServiceClient("BasicHttpBinding_IStoreService");

            DataSet ds = proxy.GetStores();

            DataTable dt = ds.Tables["Stores"];

            dataGridView1.DataSource = dt;

            proxy.Close();

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string store_name = textBox1.Text;

            StoreServiceReference.StoreServiceClient proxy = new StoreServiceReference.StoreServiceClient("BasicHttpBinding_IStoreService");

            DataSet ds = proxy.GetStoresByName(store_name);

            DataTable dt = ds.Tables["Stores"];

            dataGridView1.DataSource = dt;
            proxy.Close();
        }

        private void category_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string store_cat = category_list.SelectedItem.ToString();

            StoreServiceReference.StoreServiceClient proxy = new StoreServiceReference.StoreServiceClient("BasicHttpBinding_IStoreService");

            DataSet ds = proxy.GetStoresByCategory( store_cat );

            DataTable dt = ds.Tables["Stores"];

            dataGridView1.DataSource = dt;
            proxy.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
