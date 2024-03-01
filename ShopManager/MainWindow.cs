using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManager
{
    public partial class MainWindow : Form
    {
        LoginWindow _parent;
        employee _employee;

        public employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }
        public MainWindow(LoginWindow Parent, employee Employee)
        {
            this._parent = Parent;
            this._employee = Employee;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _employee = null;
            GC.Collect();
            this.Hide();
            _parent.Show();
        }
    }
}
