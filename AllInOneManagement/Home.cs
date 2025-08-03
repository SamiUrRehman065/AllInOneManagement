namespace FactoryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lbldate.Text = "Date: " + DateTime.Now.ToLongDateString();

        }

        private async Task LoadControl(UserControl control)
        {
            MainPanel.Controls.Clear(); // Clear previous content
            control.Dock = DockStyle.Fill; // Make it fit the panel

            control.Margin = new Padding(2);

            MainPanel.Padding = new Padding(10); // Adjust as needed

            await Task.Run(() =>
            {
                Invoke(new Action(() =>
                {
                    MainPanel.Controls.Add(control); // Add new control inside Invoke
                }));
            });


        }

        private async void Home_Load(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
            await LoadControl(new UserControls.Orders());
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new();
            login.ShowDialog();
            this.Close();
        }

        private async void BtnOrders_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.Orders());
            lbldashboard.Text = "Orders";

        }

        private async void Btnledger_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.Ledgers());
            lbldashboard.Text = "Ledgers";
        }

        private async void BtnRawMaterial_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.Rawmaterials());
            lbldashboard.Text = "Raw Materials";
        }

        private async void BtnProduction_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.Production());
            lbldashboard.Text = "Production";
        }

        private async void Btncashflow_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.CashFlow());
            lbldashboard.Text = "CashFlow";
        }

        private async void BtnSummary_Click(object sender, EventArgs e)
        {

            await LoadControl(new UserControls.SummaryControls.Summary());
            lbldashboard.Text = "Summary";
        }

        private async void btnRMLedger_Click(object sender, EventArgs e)
        {
            await LoadControl(new UserControls.RawMaterialLedgerControls.RawMaterialLedger());
            lbldashboard.Text = "Raw Material Ledger";
        }
    }
}
