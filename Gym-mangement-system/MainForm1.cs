using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_mangement_system
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add member

            AddMember addMember=new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Item viewMember = new View_Item();
            viewMember.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }
    }
}
