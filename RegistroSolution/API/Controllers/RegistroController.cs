using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Negocio.Servicies;
using Entidades.Modelos;


namespace API.Controllers
{
    public class RegistroController : ApiController
    {
        private RegistroBL bl = new RegistroBL();

        [HttpGet]
        public List<registro> Get()
        {
            return bl.Listar();
        }
    }
}