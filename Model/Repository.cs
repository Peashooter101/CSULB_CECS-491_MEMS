﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public interface IRepository<T> where T : IEntity
    {
        void Create(T entity);
        T Read(ObjectId id);
        void Update(T entity);
        void Delete(ObjectId id);
    }
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collection;

        public Repository(IMongoDatabase database, string collectionName)
        {
            _collection = database.GetCollection<T>(collectionName);
        }

        public void Create(T entity)
        {
            _collection.InsertOne(entity);
        }

        public void Delete(ObjectId id)
        {
            _collection.DeleteOne(e => e.Id == id);
        }

        public T Read(ObjectId id)
        {
            return _collection.Find(e => e.Id == id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            _collection.ReplaceOne(e => e.Id == entity.Id, entity);
        }
    }
}
