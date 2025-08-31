using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow
{
    public partial class EmployeeDeletionFlow : Form
    {
        public EmployeeDeletionFlow()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
