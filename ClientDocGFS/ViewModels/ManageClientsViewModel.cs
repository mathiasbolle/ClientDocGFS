using System.Collections.Generic;
using ClientDocGFS.Domain;
using ClientDocGFS.Service;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.ViewModels;

public class ManageClientsViewModel : ViewModelBase
{
    private IClientService clientService;
    public IEnumerable<ClientDto> Clients { get; set; } //should be changed

    public ManageClientsViewModel(IClientService clientService)
    {
        this.clientService = clientService;
        
        Clients = this.clientService.GetAll();
        this.clientService.CreateAsync(new ClientRequest.Create() { FirstName = "Mathias", LastName = "Bolle"});
    }
}