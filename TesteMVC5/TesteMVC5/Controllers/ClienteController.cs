using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        [Route("novo-cliente")]
        public ActionResult NovoCliente(Cliente cliente)
        {
            return View(cliente);
        }
    }
}