
using CuaHangDienTu.UI.Product;

namespace CuaHangDienTu.UI.Main
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        public event Action LogoutClicked;



        public void CloseForm()
        {
            this.Close();
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



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            string con = "Data Source=localhost,1433;Initial Catalog=CuaHangDienTu;Trusted_Connection=Yes";


        }

        private void btn__product_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ProductView productView = new ProductView();
            productView.Dock = DockStyle.Fill;
            panel1.Controls.Add(productView);
        }

        private void btn__home_Click(object sender, EventArgs e)
        {
            ClearPanel();
            HomeView homeView = new HomeView();
            homeView.Visible = true;
            homeView.Dock = DockStyle.Fill;
            homeView.BringToFront();
            homeView.Location = new Point(0, 0);
            panel1.Controls.Add(homeView);
        }

        private void btn__logout_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
