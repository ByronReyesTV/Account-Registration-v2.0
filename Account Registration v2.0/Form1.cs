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
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public TextBox tb1;
        public ComboBox cb1;
        public TextBox tb2;
        public TextBox tb3;
        public TextBox tb4;
        public TextBox tb5;
        public TextBox tb6;
        public RichTextBox rb1;


        public Form1()
        {
            InitializeComponent();
            instance = this;

            tb1 = textBox1;
            cb1 = comboBox1;
            tb2 = textBox2;
            tb3 = textBox3;
            tb4 = textBox4;
            tb5 = textBox5;
            tb6 = textBox6;
            rb1 = richTextBox1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Next */
            Form2 form = new Form2();
            form.Show();
            this.Hide();

            /* data sent in form2 */
            Form2.instance.lab9.Text = textBox1.Text;
            Form2.instance.lab10.Text = comboBox1.Text;
            Form2.instance.lab11.Text = textBox2.Text;
            Form2.instance.lab12.Text = textBox3.Text;
            Form2.instance.lab13.Text = textBox4.Text;
            Form2.instance.lab14.Text = textBox5.Text;
            Form2.instance.lab15.Text = textBox6.Text;
            Form2.instance.lab16.Text = richTextBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Clear Button */
            textBox1.Clear();
            comboBox1.ResetText();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
        }
    }
}
