using System;
using System.Collections.Generic;
using ClientDocGFS.Domain;
using ClientDocGFS.Service;
using ClientDocGFS.Shared.Client;
using Microsoft.CodeAnalysis;

namespace ClientDocGFS.ViewModels;

public class ManageClientsViewModel : ViewModelBase
{
    private IClientService clientService;
    public IEnumerable<ClientDto> Clients { get; set; } //should be changed

    public ManageClientsViewModel(IClientService clientService)
    {
        this.clientService = clientService;
        
        this.clientService.CreateAsync(new ClientRequest.Create() { FirstName = "Mathias", LastName = "Bolle"});
        Clients = this.clientService.GetAll();
        
        
        //log clients
        foreach (var clientDto in Clients)
        {
            Console.WriteLine(clientDto);
        }
        
    }
}