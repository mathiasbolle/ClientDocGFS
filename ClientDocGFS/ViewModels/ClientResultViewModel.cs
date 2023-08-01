using ClientDocGFS.Domain;

namespace ClientDocGFS.ViewModels;

public class ClientResultViewModel: ViewModelBase
{
    private readonly Client client;

    public ClientResultViewModel(Client client)
    {
        this.client = client;
    }
}