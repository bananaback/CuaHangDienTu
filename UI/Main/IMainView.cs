namespace CuaHangDienTu.UI.Main
{
    public interface IMainView
    {
        void AttachPresenter(IMainPresenter presenter);
        event Action LogoutClicked;
        void CloseForm();
    }
}
