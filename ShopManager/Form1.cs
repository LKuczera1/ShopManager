using System.Data;

namespace ShopManager
{
    public partial class LoginWindow : Form
    {

        MainWindow _mainWindow;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            DataTable answer = _connector.databaseQuery("select * from employees where login = '" + LoginTextBox.Text+"'");


            if(answer.IsInitialized)
            {
                int y_size = answer.Columns.Count;
                int x_size = answer.Rows.Count;

                if(x_size==0) MessageBox.Show("User with this login does not exists", "User not fund", MessageBoxButtons.OK);

                for(int i=0;i<x_size;i++)
                {
                    if (answer.Rows[i][2].ToString() == PasswordTextBox.Text.ToString())
                    {
                        _mainWindow = new MainWindow(this, new employee((int)answer.Rows[0][0], answer.Rows[0][1].ToString(), answer.Rows[0][3].ToString(), answer.Rows[0][4].ToString()));
                        _mainWindow.Show();



                        this.Hide();
                        LoginTextBox.Text = "";
                        PasswordTextBox.Text = "";
                        _mainWindow.Text += " as " + _mainWindow.Employee.Name;

                        return;
                    }
                }

                MessageBox.Show("Invalid Password", "Invalid Password", MessageBoxButtons.OK);
            }
        }
    }
}
