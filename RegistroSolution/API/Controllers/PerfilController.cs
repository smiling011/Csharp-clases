using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Negocio.Servicies;
using Entidades.Modelos;

namespace API.Controllers
{
    public class PerfilController : ApiController
    {
        private PerfilBL bl = new PerfilBL();

        [HttpGet]
        public List<perfil> Get()
        {
            return bl.Listar();
        }
    }
}