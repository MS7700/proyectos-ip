using CreacionWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CreacionWS.Controllers
{
    public class PeriodosController : ApiController
    {
        private NominaContext db = new NominaContext();
        [ResponseType(typeof(IQueryable<String>))]
        public IHttpActionResult GetPeriodos()
        {
            IQueryable<String> periodos = db.Registros.Select(r => r.Periodo).Distinct();
            if (periodos == null)
            {
                return NotFound();
            }
            return Ok(periodos);
        }
    }
}
