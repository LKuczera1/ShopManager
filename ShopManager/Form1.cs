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
            //DataSet answer = _connector.databaseQuery("select * from worker where login = " + LoginTextBox.Text);
            DataTable answer = _connector.databaseQuery("select * from worker");


            if(answer.IsInitialized)
            {
                int y_size = answer.Columns.Count;
                int x_size = answer.Rows.Count;
                

            }
        }
    }
}
