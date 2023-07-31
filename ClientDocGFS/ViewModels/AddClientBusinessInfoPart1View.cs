using System;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.ViewModels;

public class AddClientBusinessInfoPart1View: ViewModelBase
{

    private readonly Client client;
    
    public AddClientBusinessInfoPart1View(Client client)
    {
        this.client = client;
        Console.WriteLine(client);
    }

}