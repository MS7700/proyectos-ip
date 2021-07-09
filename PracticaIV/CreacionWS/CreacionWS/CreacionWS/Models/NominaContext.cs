using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CreacionWS.Models
{
    public class NominaContext : DbContext
    {
        public NominaContext() : base("NominaDB") {
            Database.SetInitializer<NominaContext>(new NominaDBInitializer<NominaContext>());
        }
        public virtual DbSet<Registro> Registros { get; set; }


        private class NominaDBInitializer<T> : DropCreateDatabaseAlways<NominaContext>
        {
            protected override void Seed(NominaContext context)
            {
                IList<Registro> registros = new List<Registro>();
                registros.Add(new Registro(1, "00122233344", 34000, "Julio 2021"));
                registros.Add(new Registro(2, "12223334555", 40000, "Julio 2021"));
                registros.Add(new Registro(3, "33344455566", 28000, "Julio 2021"));
                registros.Add(new Registro(4, "77788899900", 44000, "Julio 2021"));

                registros.Add(new Registro(5, "00122233344", 34000, "Junio 2021"));
                registros.Add(new Registro(6, "12223334555", 40000, "Junio 2021"));
                registros.Add(new Registro(7, "33344455566", 28000, "Junio 2021"));
                registros.Add(new Registro(8, "77788899900", 44000, "Junio 2021"));

                registros.Add(new Registro(9, "00122233344", 34000, "Mayo 2021"));
                registros.Add(new Registro(10, "12223334555", 40000, "Mayo 2021"));
                registros.Add(new Registro(11, "33344455566", 28000, "Mayo 2021"));
                registros.Add(new Registro(12, "77788899900", 44000, "Mayo 2021"));
                foreach (Registro registro in registros)
                {
                    context.Registros.Add(registro);
                }
                    
                base.Seed(context);
            }
        }
    }
}