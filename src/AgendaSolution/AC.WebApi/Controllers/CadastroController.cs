using AC.BLL;
using AC.Domain;
using AC.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AC.WebApi.Controllers
{
    public class CadastroController : Controller
    {

        public ActionResult Index()
        {
            ListaGrid();
            return View();
        }
 
              
        [HttpPost]
        public ActionResult Create(Contato model)
        {
            var app = new ContatoBLL();
            var contato = app.Create(model);
            ListaGrid();
            return View("Index");
        }



























        public void ListaGrid()
        {
            var app = new ContatoBLL();

            var contatos = app.ListarContatos();

            ViewBag.Contatos = contatos.ToList();
        }

    }

}