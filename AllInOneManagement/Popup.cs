namespace FactoryManagementSystem
{
    public partial class Popup : Form
    {
        public Popup(Control ctrl)
        {
            InitializeComponent();
            ctrl.Dock = DockStyle.Fill;
            this.Width = ctrl.Width + 2;
            this.Height = ctrl.Height + 2;
            this.Controls.Add(ctrl);
        }
    }
}
