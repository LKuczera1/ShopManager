using System.Data;

namespace ShopManager
{
    public partial class LoginWindow : Form
    {
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
                        return;
                    }
                }

                MessageBox.Show("Invalid Password", "Invalid Password", MessageBoxButtons.OK);
            }
        }
    }
}
