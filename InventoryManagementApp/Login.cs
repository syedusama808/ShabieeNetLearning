using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private SqlCommand cmd;

        private void Login_Load(object sender, EventArgs e)
        {
            string connectionPath = @"Data Source=localhost;Initial Catalog=InventoryManagement;Persist Security Info=True;User ID=sa;Password=SyedUsama808@;Encrypt=False;";
            conn = new SqlConnection(connectionPath);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            MessageBox.Show("Database Connected.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            string query = "INSERT INTO Product (Name) VALUES ('"+ productName +"')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
        }
    }
}
