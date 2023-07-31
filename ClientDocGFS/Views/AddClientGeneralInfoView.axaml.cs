using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ClientDocGFS.Views;

public partial class AddClientGeneralInfoView : UserControl
{
    public AddClientGeneralInfoView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}