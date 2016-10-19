using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eyect4rails.Classes;
using eyect4rails.Enums;
using eyect4rails.IRepository;
using eyect4rails.Logic;
using eyect4rails.Repositories;

namespace eyect4rails
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                //Admin
                case 1: RemiseForm remiseForm = new RemiseForm();
                    this.Hide();
                    remiseForm.Show();
                    break;
                //Wagenparkbeheerder
                case 2:
                    break;
                //Driver
                case 3:
                    break;
                //Cleaner
                case 4:
                    break;
                //Mechanic
                case 5:
                    break;

                default:
                    break;
            }
        }
    }
}
