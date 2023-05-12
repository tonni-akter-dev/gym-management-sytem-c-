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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Project-uni\Gym-mangement-system\GymDb.mdf;Integrated Security=True;Connect Timeout=30");









        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //add
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTbl values('" + NameTb.Text + "','" + PhoneTb.Text + "','" + GenderCb.SelectedItem.ToString() + "'," + AgeTb.Text + " ," + AmountTb.Text + ",'" + TimingCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Con.Close();
                    AmountTb.Text = "";
                    AgeTb.Text = "";
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.Text = "";
                    TimingCb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //reset
        {
            AmountTb.Text="";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm1 mainform = new MainForm1();
            mainform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
