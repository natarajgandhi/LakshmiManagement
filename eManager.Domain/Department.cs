using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eManager.Domain
{
    public class Department
    {
        private int _Id;

        /// <summary>
        /// Id of Department
        /// </summary>
        public virtual int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _name;

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private ICollection<Employee> _employeees;

        public virtual ICollection<Employee> Employees
        {
            get { return _employeees; }
            set { _employeees = value; }
        }
        
        
        
    }
}
