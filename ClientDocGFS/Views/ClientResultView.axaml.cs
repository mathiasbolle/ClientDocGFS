using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ClientDocGFS.Views;

public partial class ClientResultView : UserControl
{
    public ClientResultView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}