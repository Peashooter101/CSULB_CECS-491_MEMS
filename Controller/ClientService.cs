using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public class ClientService
    {
        private readonly DatabaseContext _dbContext;

        public ClientService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateClient(string clientName)
        {
            var clientRepository = new Repository<Client>(_dbContext.database, "Clients");
            var newClient = new Client
            {
                name = clientName
            };
            clientRepository.Create(newClient);
        }
    }
}
