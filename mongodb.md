# MongoDB Stuff

MongoDB research and implementation notes.

## Database Connection

- The connection string contains the Username and Password. There are a few ways to handle implementing this.
    1. They provide the connection string, but leave `<password>` unchanged. We have another text box where they put their password. Simplifies having them do anything except copying and pasting.
    2. They provide the whole connection string, where they also stuck their password into `<password>`.
- The object type for the Cluster is `MongoClient` and is initialized with `new MongoClient(connectionString)`.
    - `Environment.GetEnvironmentVariable()` can be used to get an environment variable. Will return `null` if the environment variable does not exist.
    - `Environment.SetEnvironmentVariable()` can be used to set an environment variable. This one we can use to store the connection string in the system.

## Creating Databases, Collections, and Documents within the Cluster

```cs
string connectionString = Environment.GetEnvironmentVariable("MONGO_DB_URI");
MongoClient client = new MongoClient(connectionString);
```
- You can access a collection of objects with the following: `IMongoCollection<ObjectType> collection = client.GetDatabase("database_name").GetCollection<ObjectType>("collection_name");`
    - You "create" these collections and databases by inserting data into it or creating an index off of them.
    - I genuinely do not know how to create collections otherwise.

### Creating an Index

- You can create an index using `collection.Indexes.CreateOne(new CreateModelIndex<ObjectType>(index));`
    - `index` is `Builders<ObjectType>.IndexKeys.Something(lambda)`
        - `Something()` would be how you're indexing, so `Ascending()` for example.
        - `lambda` is what is compared, so if `ObjectType` has an `int num`, `item => item.num` would be the lambda.

### Adding a Document

- You can add a document using `collections.InsertOne(objectTypeVariable);`
    - `collections.InsertMany()` is used to insert more than one.
- You can either create the object in the declaration or just provide the object variable. Either way works.

```cs
collection.InsertOne(new TestModel
{
    number = 5,
    coolGuy = ":D"
});
```

### Deleting a Document

- You can delete a document using `collections.DeleteOne(lambda)` or `collections.DeleteMany(lambda)`.
    - `lambda` must produce a `true` or `false`. For example, `item => item.variable == "something"`.

```cs
collection.DeleteOne(item => item.coolGuy == ":D");
collection.DeleteMany(item => item.coolGuy == ":D");
```

### BSon Documents

BSonDocument is how MongoDB's C# Driver handles the JSON-like document objects. We should not ever need to use this since we are working with actual objects, but in the event we need to...

- When using `BSonDocument` as your ObjectType, Key Values are provided in this way: `new BsonDocument { {"key1", "value1"}, {"key2", "value2"} }`.
    - This is very similar to how you add Objects within Objects.
        - In JSON, you can put an inner object using `{ key: {a: 'a', b: 'b'} }`, this is what I am talking about. We may not need this since most of our objects either contain data or a BSON reference.

```cs
collection.InsertOne(new BsonDocument
{
    {"yes", "no"},
    {"no", "yes"}
});
```

## Sync VS Async

Most of the functions have a Synchronous and Asynchronous function. There are may cases in which we can use either, but I find that we may be using Synchronous in many cases, despite Async being always a nice thing to have.

- `InsertOne()` has `InsertOneAsync()`, pretty sure most of the methods follow this.
- When handling Async, you need to `await` before doing things to it.
- We should use Synchronous functions for when the user is adding / saving changes to the database. We won't need to worry about the Async case and what the user might do in the background when we can literally just freeze the program whenever we wish, in these cases.
- Async would be better for obtaining data and populating information, in my opinion.