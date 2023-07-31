using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;
using ReactiveUI;

namespace ClientDocGFS.ViewModels;

public class AddClientGeneralInfoViewModel: ViewModelBase
{

    private readonly Client client;
    public AddClientGeneralInfoViewModel(Client client)
    {
        this.client = client;
    }

    public string firstAndLastName
    {
        get => client.FirstName + " " + client.LastName;
        set => client.FirstName = value;
    }

    public string firstAndLastNameParter
    {
        get => client.FirstNameParter + " " + client.LastnameParter;
        set => client.LastnameParter = value;
    }

    public string AdresStreet
    {
        get => client.AdressStreetName;
        set => client.AdressStreetName = value;
    }

    public int AddressNumber
    {
        get => client.CityNumber;
        set => client.CityNumber = value;
    }

    public string CityName
    {
        get => client.CityName;
        set => client.CityName = value;
    }

    public string PhoneNumber
    {
        get => client.PhoneNumber;
        set => client.PhoneNumber = value;
    }

    public string Mail
    {
        get => client.MailAdress;
        set => client.MailAdress = value;
    }

}