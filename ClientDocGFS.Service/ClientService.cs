using ClientDocGFS.Data;
using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.Service;

/**
 * NOT async version
 */
public class ClientService : IClientService
{
    private readonly GfsContext db;

    public ClientService(GfsContext context)
    {
        db = context;
        db.Database.EnsureCreated();
    }

    //fix this to convert to Dto
    public IEnumerable<ClientDto> GetAll()
    {
        var queryable = db.Clients.Select(client => client);

        return queryable.AsEnumerable();
    }

    public void CreateAsync(ClientRequest.Create Modal)
    {
        db.Clients.Add(
            new ClientDto()
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
    }
}