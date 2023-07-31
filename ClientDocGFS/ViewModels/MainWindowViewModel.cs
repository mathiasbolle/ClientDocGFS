using System;
using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;
using ReactiveUI;

namespace ClientDocGFS.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    private Client client = new();

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
        ContentViewModel = new AddClientGeneralInfoViewModel(client);
    }

    public void ManageClients()
    {
        ContentViewModel = new ManageClientsViewModel();
    }

    public void BackToHome()
    {
        ContentViewModel = new HomeViewModel();
    }

    public void GoToFormStep2()
    {
        ContentViewModel = new AddClientBusinessInfoPart1View(client);
    }


}