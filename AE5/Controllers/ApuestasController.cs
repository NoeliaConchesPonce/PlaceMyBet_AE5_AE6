﻿using AE5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AE5.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
        public IEnumerable<Apuesta> Get()
        {
            var repo = new ApuestasRepository();
            List<Apuesta> apuestas = repo.retrieve();
            return apuestas;
        }

        // GET: api/Apuestas/5
        public Apuesta Get(int id)
        {
            var repo = new ApuestasRepository();
             Apuesta apuesta = repo.retireveId(id);
            return apuesta;
        }

        // POST: api/Apuestas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
