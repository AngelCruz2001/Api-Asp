using ApiRest.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest
{
    public class Context
    {
        private readonly IMongoDatabase database;
        public Context()
        {
            database = new MongoClient("mongodb://JpgAngel:Jpg1407a@ds018568.mlab.com:18568/jpginvidentes").GetDatabase("jpginvidentes");

        }
        public IMongoCollection <usuarios> usuarios
        {
            get
            {
                return database.GetCollection<usuarios>("usuarios" );
            }
            //alp
        }

    }
}

