using CuaHangDienTu.UI.Login;
using Microsoft.Extensions.DependencyInjection;

namespace CuaHangDienTu.UI.Main
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private IServiceProvider _serviceProvider;
        public MainPresenter(IServiceProvider serviceProvider, IMainView mainView)
        {
            _mainView = mainView;
            //_mainView.AttachPresenter(this);
            _mainView.LogoutClicked += Logout;
            _serviceProvider = serviceProvider;

        }

        private void Logout()
        {
            _mainView.LogoutClicked -= Logout;
            _mainView.CloseForm();
            var loginView = _serviceProvider.GetRequiredService<ILoginView>();
            var loginPresenter = new LoginPresenter(_serviceProvider, loginView);
            loginView.Show();
        }
    }
}
