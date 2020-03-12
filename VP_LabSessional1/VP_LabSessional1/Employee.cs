using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_LabSessional1
{
    class Employee
    {
        private string id;
        private string name;
        private int salary;
        private string designation;

        public Employee()
        {
            this.id = null;
            this.name = null;
            this.salary = 0;
            this.designation = null;
        }

        public Employee(string i, string n, int s, string d)
        {
            this.id = i;
            this.name = n;
            this.salary = s;
            this.designation = d;
        }

        public string ID 
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }

        public string Designation
        {
            get
            {
                return this.designation;
            }
            set
            {
                this.designation = value;
            }
        }
    }
}
