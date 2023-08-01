using ClientDocGFS.Domain;
using ClientDocGFS.Shared.Client;

namespace ClientDocGFS.Service;

/**
 * Service for CRUD operations
 */
public interface IClientService
{
    //public async Task

    public IEnumerable<Client> GetAll();

    public Task<int> CreateAsync(ClientRequest.Create Modal);
}