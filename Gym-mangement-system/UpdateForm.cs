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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm1 mainform = new MainForm1();
            mainform.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Project-uni\Gym-mangement-system\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string query = "select*from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            TimingCb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the member to be deleted");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where MId=" + key + ";";
                    SqlCommand sqlCommand = new SqlCommand(query,Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfully");

                    Con.Close();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0  || NameTb.Text=="" || PhoneTb.Text=="" ||AgeTb.Text=="" || AmountTb.Text=="" || GenderCb.Text=="" || TimingCb.Text=="")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set MName='" + NameTb.Text + "',MPhone='" + PhoneTb.Text + "',MGen='" + GenderCb.Text + "',MAge="+ AgeTb.Text + ",MAmount=" + AmountTb.Text + ",MTiming='" + TimingCb.Text+"'where MId="+key+";";



                    SqlCommand sqlCommand = new SqlCommand(query, Con);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully");

                    Con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
