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
    public partial class RemiseForm : Form
    {
        public RemiseForm()
        {
            InitializeComponent();
        }

        private void plaatsenTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaatsenTramForm plaatsenTramForm = new PlaatsenTramForm();
            plaatsenTramForm.Show();
        }

        private void verwijderTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerwijderTramForm verwijderTramForm = new VerwijderTramForm();
            verwijderTramForm.Show();
        }

        private void reserveerTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveerTramForm reserveerTramForm = new ReserveerTramForm();
            reserveerTramForm.Show();
        }

        private void veranderStatusTramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeranderStatusTramForm veranderStatusTramForm = new VeranderStatusTramForm();
            veranderStatusTramForm.Show();
        }

        private void tramInformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TramInformatieForm tramInformatieForm = new TramInformatieForm();
            tramInformatieForm.Show();
        }

        private void spoorInformatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpoorInformatieForm spoorInformatieForm = new SpoorInformatieForm();
            spoorInformatieForm.Show();
        }
        
        private void veranderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeranderStatusSpoorForm veranderStatusSpoorForm = new VeranderStatusSpoorForm();
            veranderStatusSpoorForm.Show();
        }

        private void updateSpoorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSpoorForm updateSpoorForm = new UpdateSpoorForm();
            updateSpoorForm.Show();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
