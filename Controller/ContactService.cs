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

		public void CreateContact()
		{

			var newContact = new Contact()
			{
				name = name,
				email = email,
				phoneNumber = phoneNumber,
				businessLocation = businessLocation
			};
			this.contactRepository.Create(newContact);
		}

		public Contact ReadContact(ObjectId id)
		{
			var filter = Builders<Contact>.Filter.Eq(m => m.Id, id);
			return contactRepository.Find(filter).FirstOrDefault();
		}

		public List<Contact> GetContactsByMachine (ObjectId id)
		{

		}

	}
}