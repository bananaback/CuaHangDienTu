namespace CuaHangDienTu.UI.Login
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void ShowError(string message);
        void CloseForm();
        event Action LoginClicked;
        void Show();
        void AttachPresenter(ILoginPresenter loginPresenter);
    }
}
