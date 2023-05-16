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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void UidTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewEquipment vequipment = new viewEquipment();
            vequipment.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        { //back
            MainForm1 mainform = new MainForm1();
            mainform.Show();
            this.Hide();
        }
       // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Project-uni\Gym-mangement-system\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        { //save into database 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Project-uni\Gym-mangement-system\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            try
            {
              //  Int64 cost =Int64.Parse(EquipCostTb.Text);
                string str = "INSERT INTO equipment (EName,EDesc,Emus,ECost) VALUES('" + EquipNameTb.Text + "','" + EquiDescTb.Text + "','" + EquiMuscleTb.Text + "','" + EquipCostTb.Text + "'); ";
                
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(EId) from equipment;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + EquipNameTb.Text + "'s Equipment Details is Inserted Successfully.. ");
                   // this.Hide();
                }
               // this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
            EquipNameTb.Text = "";
            EquiDescTb.Text = "";
            EquiMuscleTb.Text = "";
            EquipCostTb.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipNameTb.Text = "";
            EquiDescTb.Text = "";
            EquiMuscleTb.Text = "";
            EquipCostTb.Text = "";
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
    }
}
