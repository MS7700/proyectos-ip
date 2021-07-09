using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CreacionWS.Models;

namespace CreacionWS.Controllers
{
    public class RegistroesController : ApiController
    {
        private NominaContext db = new NominaContext();

        // GET: api/Registroes
        [ResponseType(typeof(IQueryable<Registro>))]
        [Route("api/Registroes/{periodo?}")]
        public IHttpActionResult GetRegistros(string periodo = null)
        {
            IQueryable<Registro> registros;
            if (periodo == null)
            {
                registros = db.Registros;
            }
            else
            {
                registros = db.Registros.Where(r => r.Periodo == periodo);
            }
            if (registros == null)
            {
                return NotFound();
            }
            return Ok(registros);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistroExists(int id)
        {
            return db.Registros.Count(e => e.ID == id) > 0;
        }
    }
}