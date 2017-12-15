using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Emp
    {
        private string name;
        private decimal salary;

        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Emp(string newName, decimal newSalary)
        {
            name = newName;
            salary = newSalary;
        }

        public override string ToString()
        {
            return string.Format("name: {0,-20}\tsalary: {1:C}\r\n",
                                        name, salary);
        }

    }
}
