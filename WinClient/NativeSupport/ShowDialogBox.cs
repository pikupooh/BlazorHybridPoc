using RazorSharedLibrary.NativeClientInterfaces;
using System.Windows;

namespace WinClient.NativeSupport;

public class ShowDialogBox : IShowDialogBox
{
    public void Show()
    {
        MessageBox.Show(messageBoxText: "test");
    }
}
