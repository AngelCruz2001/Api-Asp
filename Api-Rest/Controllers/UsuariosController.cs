using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRest.Models;
using Microsoft.AspNetCore.Http;                    
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
//Comentando para poder hacer n commit
namespace ApiRest.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuarios")]
    public class UsuariosController : Controller
    {
        private Context context;

        public UsuariosController()
        {
            context = new Context();
        }
        // GET: api/Usuarios
        [HttpGet]
        public IEnumerable<usuarios> Get()
        {
            var Usuarios = context.usuarios.Find(_ => true).ToList();
            return Usuarios;
            //Lo que caiga
        }

        // GET: api/Usuarios/5
        [HttpGet("{UserName}", Name = "Get")]
        public IEnumerable<usuarios> Get(string username)
        {
            var Usuarios = context.usuarios.Find(x => x.UserName==username).ToList();
            return Usuarios;
        }
        
        // POST: api/Usuarios
        [HttpPost]
        public void Post([FromBody]usuarios Usuarios)
        {
            context.usuarios.InsertOne(Usuarios);
        }
        
        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
