using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Models
{
    public class usuarios
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public String Nombre { get; set; }
        public String UserName { get; set; }
        public int Edad { get; set; }
        public String Domicilio { get; set; }
        public String Celular { get; set; }
        public String ContactoEmergencia { get; set; }
        public String Genero { get; set; }
        public String UbicacionActual { get; set; }
        public String LugarReciente { get; set; }
        public int __v { get; set; }
    }
}
