using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ClientDocGFS.Views;

public partial class AddClientView : UserControl
{
    public AddClientView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}