using CuaHangDienTu.UI.Main;

namespace CuaHangDienTu.UI.Login
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView _loginView;
        private IServiceProvider _serviceProvider;
        public LoginPresenter(IServiceProvider serviceProvider, ILoginView loginView)
        {
            _loginView = loginView;
            _serviceProvider = serviceProvider;
            var currentHashCode = _loginView.GetHashCode();
            _loginView.AttachPresenter(this);
            _loginView.LoginClicked += HandleLogin;

        }
        public void HandleLogin()
        {
            if (IsValidUser(_loginView.Username, _loginView.Password))
            {
                MessageBox.Show("Login Success");
                OpenMainForm();
                _loginView.LoginClicked -= HandleLogin;
                _loginView.CloseForm();
            }
            else
            {
                MessageBox.Show("Login Failed.");
            }
        }

        private void OpenMainForm()
        {
            var mainForm = new MainForm();
            var mainPresenter = new MainPresenter(_serviceProvider, mainForm);
            mainForm.Show();
        }

        private bool IsValidUser(string username, string password)
        {
            if (username == "tin" && password == "tin123")
            {
                return true;
            }
            return false;
        }
    }
}
