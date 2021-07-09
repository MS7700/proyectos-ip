using Interfaz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.App
{
    class NominaWebService
    {
        static HttpClient client = new HttpClient();
        static bool clientActivated = false;
        static void InitializeHttpClient()
        {
            if (!clientActivated)
            {
                client.BaseAddress = new Uri("https://localhost:44301/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                clientActivated = true;
            }
            
        }
        

        //static async Task RunAsync()
        //{
        //    client.BaseAddress = new Uri("https://localhost:44301/");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));
        //    String periodo = "Julio 2021";
        //    //IQueryable<Registro> nomina = await GetNominaAsync("api/Registroes/" + periodo);
        //}

        public static async Task<IList<Registro>> GetNominaAsync(string periodo)
        {
            InitializeHttpClient();
            IList<Registro> nomina = null;
            HttpResponseMessage response = await client.GetAsync("api/Registroes/" + periodo);
            if (response.IsSuccessStatusCode)
            {
                nomina = await response.Content.ReadAsAsync<IList<Registro>>();
            }
            return nomina;
        }

        public static async Task<IList<String>> GetPeriodosAsync()
        {
            InitializeHttpClient();
            IList<String> periodo = null;
            HttpResponseMessage response = await client.GetAsync("api/Periodos");
            if (response.IsSuccessStatusCode)
            {
                periodo = await response.Content.ReadAsAsync<IList<string>>();
            }
            return periodo;
        }

        public static async Task<String> GetStringAsync(string periodo)
        {
            InitializeHttpClient();
            //IQueryable<Registro> nomina = null;
            var response = await client.GetStringAsync("api/Registroes/" + periodo);
            
            return response;
        }
    }
}
