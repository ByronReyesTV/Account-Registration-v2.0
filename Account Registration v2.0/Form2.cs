using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration_v2._0
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
       
        /* fom1 connection */
        public Label lab9;
        public Label lab10;
        public Label lab11;
        public Label lab12;
        public Label lab13;
        public Label lab14;
        public Label lab15;
        public Label lab16;

        public Form2()
        {
            InitializeComponent();
            instance = this;

            /* output */
            lab9 = label9;
            lab10 = label10;
            lab11 = label11;
            lab12 = label12;
            lab13 = label13;
            lab14 = label14;
            lab15 = label15;
            lab16 = label16;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

            /* Return to form1 */
            Form1.instance.tb1.Text = lab9.Text;
            Form1.instance.cb1.Text = lab10.Text;
            Form1.instance.tb2.Text = lab11.Text;
            Form1.instance.tb3.Text = lab12.Text;
            Form1.instance.tb4.Text = lab13.Text;
            Form1.instance.tb5.Text = lab14.Text;
            Form1.instance.tb6.Text = lab15.Text;
            Form1.instance.rb1.Text = lab16.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label17.Text = "Registration Successfull";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
