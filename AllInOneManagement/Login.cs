namespace FactoryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Admin" && txtPass.Text == "Admin123")
            {
                this.Hide();
                Home home = new();

                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
