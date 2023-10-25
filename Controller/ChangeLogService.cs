using System.Collections.Generic;
using MongoDB.Driver;
using System;

namespace MEMS
{
    public class ChangeLogService
    {
        private readonly DatabaseContext _dbContext;
        private Repository<ChangelogEntry> changelogRepository;
        
        public ChangeLogService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            changelogRepository = new Repository<ChangelogEntry>(_dbContext.database, "ChangelogEntries");
        }
        
        public void CreateChange(DateTime timestamp, string type, string description)
        {
            
            var newChange = new ChangelogEntry()
            {
                timestamp = timestamp,
                type = type,
                description = description
            };
            this.changelogRepository.Create(newChange);
        }

        public List<ChangelogEntry> GetChangeLogEntries()
        {
            var filter = Builders<ChangelogEntry>.Filter.Empty;
            return changelogRepository.Find(filter)
                .SortBy(c => c.timestamp)
                .ToList();
        }
    }
}