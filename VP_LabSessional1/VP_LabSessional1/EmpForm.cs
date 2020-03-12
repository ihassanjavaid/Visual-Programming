using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VP_LabSessional1
{
    public partial class EmpForm : Form
    {
        ArrayList EmployeesList;

        public EmpForm()
        {
            InitializeComponent();
        }

        private void EmpForm_Load(object sender, EventArgs e)
        {
            EmployeesList = new ArrayList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idtofind = this.textBox5.Text.ToString();

            for ( int i = 0; i < EmployeesList.Count; i++)
            {
                Employee emptofind = (Employee) EmployeesList[i];

                if ( emptofind.ID.ToString() == idtofind)
                {
                    MessageBox.Show("Credentials: "+ emptofind.ID + " " + emptofind.Name + " " + emptofind.Salary + " " + emptofind.Designation);
                    break;
                }
       
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idtoremove = this.textBox6.Text.ToString();

            for (int i = 0; i < EmployeesList.Count; i++)
            {
                Employee emptoremove = (Employee)EmployeesList[i];

                if (emptoremove.ID == idtoremove)
                {
                    MessageBox.Show(emptoremove.ID + " is removed.");
                    EmployeesList.RemoveAt(i);
                }
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalsal = 0;

            for ( int i = 0; i < EmployeesList.Count; i++)
            {
                Employee emp = (Employee)EmployeesList[i];
                totalsal = totalsal + emp.Salary;
            }
            MessageBox.Show("Total Salary: " + totalsal);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string IDs = this.textBox1.Text.ToString();
            string Names = this.textBox2.Text.ToString();
            int sals = int.Parse(this.textBox3.Text.ToString());
            string desgns = this.textBox4.Text.ToString();

            Employee emp = new Employee(IDs, Names, sals, desgns);

            EmployeesList.Add(emp);

            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }
    }
}
