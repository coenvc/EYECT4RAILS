using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private MSSQLEmployeeRepository repository = new MSSQLEmployeeRepository();
        Employee employee = new Employee(1, "Skorchner", "s.korschner@gmail.com", 72642, "Wachtwoord123", "Tom Korschner", Role.Admin, new Address(2, "Visstraat", "Oss", "Nederland", "8175AB", "12b"), new Department(1, "SystemManagement", 4));
        public Form1()
        {
            InitializeComponent();
            EmployeeLogic employeelogic = new EmployeeLogic(repository);
            try
            {
                if (employeelogic.Delete(8) == true)
                {
                    MessageBox.Show("Success !");
                }
                
            }
            catch(SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
