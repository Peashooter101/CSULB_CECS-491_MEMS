using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MEMS
{
    public class ClientService
    {
        private readonly DatabaseContext _dbContext;
        private Repository<Client> clientRepository;

        public ClientService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            clientRepository =
                new Repository<Client>(_dbContext.database, "Clients");
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
        
        public Client ReadByName(string name)
        {
            var filter = Builders<Client>.Filter.Eq(m => m.name, name);
            return clientRepository.Find(filter).FirstOrDefault();
        }
    }
}
