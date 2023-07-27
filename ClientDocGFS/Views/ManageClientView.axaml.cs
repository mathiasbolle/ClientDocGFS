using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ClientDocGFS.Views;

public partial class ManageClientView : UserControl
{
    public ManageClientView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}