using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LabSessional1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if ( this.textBox1.Text.ToString() == "abc" && this.textBox2.Text.ToString() == "123")
            {
                EmpForm empform = new EmpForm();
                empform.Show();
            }
            else
            {
                MessageBox.Show("Wrong Credentials!");
            }
        }
    }
}
