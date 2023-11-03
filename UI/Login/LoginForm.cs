using CuaHangDienTu.UI.Login;

namespace CuaHangDienTu
{
    public partial class LoginForm : Form, ILoginView
    {
        private ILoginPresenter _presenter;
        public LoginForm()
        {
            InitializeComponent();

        }

        public void AttachPresenter(ILoginPresenter loginPresenter)
        {
            _presenter = loginPresenter;
        }

        public string Username => usernameTextBox.Text;

        public string Password => passwordTextBox.Text;

        public event Action LoginClicked;

        public void CloseForm()
        {
            this.Hide();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke();
        }
    }
}