using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace WinFormsApp1
{
    internal class Employee
    {
        public long id { get; set; }
        public string name { get; set; }
        public Department departmentId { get; set; }
        public long managerId { get; set; }
        public string email { get; set; }

    }

    internal class Department
    {
        private long id { get; set; }

        private string description { get; set; }

        private long parentID { get; set; }
    }
}
