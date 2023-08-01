using System;
using ClientDocGFS.Data;
using ClientDocGFS.Domain;
using ClientDocGFS.Service;
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
        ContentViewModel = new ManageClientsViewModel(clientService: new ClientService(new GfsContext()));
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