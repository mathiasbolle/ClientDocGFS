using ReactiveUI;

namespace ClientDocGFS.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;

    public MainWindowViewModel()
    {
        _contentViewModel = new HomeViewModel();
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void AddClient()
    {
        ContentViewModel = new AddClientViewModel();
    }

    public void ManageClients()
    {
        ContentViewModel = new ManageClientsViewModel();
    }
}