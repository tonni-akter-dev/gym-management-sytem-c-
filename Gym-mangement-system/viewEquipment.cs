using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gym_mangement_system
{
    public partial class viewEquipment : Form
    {
        public viewEquipment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Project-uni\Gym-mangement-system\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select*from equipment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            EquipSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void viewEquipment_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm1 mainform = new MainForm1();
            mainform.Show();
            this.Hide();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from  equipment where EName ='" + SearchEquip.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            EquipSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
