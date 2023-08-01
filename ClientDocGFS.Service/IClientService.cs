using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.Service;

/**
 * Service for CRUD operations
 */
public interface IClientService
{
    //public async Task

    public IEnumerable<ClientDto> GetAll();

    public void CreateAsync(ClientRequest.Create Modal);
}