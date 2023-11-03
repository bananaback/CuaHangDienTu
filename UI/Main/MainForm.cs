
using CuaHangDienTu.UI.Product;

namespace CuaHangDienTu.UI.Main
{
    public partial class MainForm : Form, IMainView
    {

        public MainForm()
        {
            InitializeComponent();

        }

        public event Action LogoutClicked;

        public void AttachPresenter(IMainPresenter presenter)
        {

        }

        public void CloseForm()
        {
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutClicked?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearPanel();
            HomeView homeView = new HomeView();
            homeView.Visible = true;
            homeView.Dock = DockStyle.Fill;
            homeView.BringToFront();
            homeView.Location = new Point(0, 0);
            panel1.Controls.Add(homeView);
        }

        private void ClearPanel()
        {
            Control[] controls = panel1.Controls.OfType<Control>().ToArray();

            // Dispose and remove the controls from the copy
            foreach (Control control in controls)
            {
                control.Dispose();
                panel1.Controls.Remove(control);
            }
        }

        private void view2Button_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ProductView productView = new ProductView();
            productView.Dock = DockStyle.Fill;
            panel1.Controls.Add(productView);
        }
    }
}
