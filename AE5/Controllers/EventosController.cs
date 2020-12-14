using AE5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE5.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<Evento> Get()
        {
            var repo = new EventosRepository();
            List<Evento> eventos = repo.retrieve();
            return eventos;
        }

        // GET: api/Eventos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Eventos
        public void Post([FromBody]Evento e)
        {
            var repo = new EventosRepository();
            repo.Save(e);
        }

        // PUT: api/Eventos/5
        public void Put(int id, string eLocal, string eVisitante)
        {
            var repo = new EventosRepository();
            repo.updateEventos(id, eLocal, eVisitante);
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
            var repo = new EventosRepository();
            repo.deleteEventos(id);
        }
    }
}
