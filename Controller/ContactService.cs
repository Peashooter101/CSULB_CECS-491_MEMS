using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MEMS
{
	public class ContactService
	{
		private readonly DatabaseContext _dbContext;
		private Repository<Contact> contactRepository;

		public ContactService(DatabaseContext dbContext)
		{
			_dbContext = dbContext;
			contactRepository =
				new Repository<Contact>(_dbContext.database, "Contacts");
		}

		public void CreateContact(string contactName, string contactEmail, string contactPhoneNumber, string contactEmployer, ObjectId contactBusinessLocation, BsonObjectId machineId)
		{

			var newContact = new Contact()
			{
				name = contactName,
				email = contactEmail,
				phoneNumber = contactPhoneNumber,
				employer = contactEmployer,
				businessLocation = contactBusinessLocation,
				machineRefId = machineId,
			};
			contactRepository.Create(newContact);
		}

		public Contact ReadContact(ObjectId id)
		{
			var filter = Builders<Contact>.Filter.Eq(m => m.Id, id);
			return contactRepository.Find(filter).FirstOrDefault();
		}

		public Contact GetContactByMachine(ObjectId id)
		{
			var filter = Builders<Contact>.Filter.Eq(c => c.machineRefId, id);
			return contactRepository.Find(filter).FirstOrDefault();
		}

	}
}