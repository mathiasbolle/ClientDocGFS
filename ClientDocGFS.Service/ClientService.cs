using ClientDocGFS.Data;
using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.Service;

public class ClientService : IClientService
{
    private readonly GfsContext db;

    public ClientService(GfsContext context)
    {
        db = context;
    }

    //fix this to convert to Dto
    public IEnumerable<Client> GetAll()
    {
        var queryable = db.Clients.Select(client => client);

        return queryable.AsEnumerable();
    }

    public Task<int> CreateAsync(ClientRequest.Create Modal)
    {
        db.Clients.Add(
            new Client()
            {
                AdressStreetName = Modal.AdressStreetName, bankNumber = Modal.bankNumber,
                bankNumberOtherCountry = Modal.bankNumberOtherCountry,
                CityName = Modal.CityName, CityNumber = Modal.CityNumber, enterpriseNumber = Modal.enterpriseNumber,
                FirstName = Modal.FirstName, FirstNameParter = Modal.FirstNameParter, kids = Modal.kids,
                LastName = Modal.LastName, LastnameParter = Modal.LastnameParter, MailAdress = Modal.MailAdress,
                PhoneNumber = Modal.PhoneNumber, nationalNumber = Modal.nationalNumber
            }
        );

        db.SaveChanges();

        return (Task<int>)Task.CompletedTask;
    }
}