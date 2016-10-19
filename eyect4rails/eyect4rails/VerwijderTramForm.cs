using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyect4rails
{
    public partial class VerwijderTramForm : Form
    {
        public VerwijderTramForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {

        }
    }
}
