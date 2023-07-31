using System;
using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.ViewModels;

public class AddClientBusinessInfoPart1View : ViewModelBase
{

    private readonly Client client;

    public AddClientBusinessInfoPart1View(Client client)
    {
        this.client = client;
        Console.WriteLine(client);
    }

    public string EnterpriseNumber
    {
        get => client.enterpriseNumber;
        set => client.enterpriseNumber = value;
    }

    public string NationalNumber
    {
        get => client.nationalNumber;
        set => client.nationalNumber = value;
    }

    public short Kids
    {
        get => client.kids;
        set => client.kids = value;
    }

    public string Banknumber
    {
        get => client.bankNumber;
        set => client.bankNumber = value;
    }

    public string BankNumberOtherCountry
    {
        get => client.bankNumberOtherCountry;
        set => client.bankNumberOtherCountry = value;
    }
} 