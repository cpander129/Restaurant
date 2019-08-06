using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class Options : Form
    {
        private String employeeId;

        public void SetEmployeeId(String employeeId)
        {
            this.employeeId = employeeId;
        }

        public String GetEmployeeId()
        {
            return employeeId;
        }

        public Options()
        {
            InitializeComponent();
        }
    }
}
