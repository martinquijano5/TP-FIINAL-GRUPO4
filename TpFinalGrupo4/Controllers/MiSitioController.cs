using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TpFinalGrupo4.Models;

namespace TpFinalGrupo4.Controllers
{
    public class MiSitioController : Controller
    {
        // GET: MiSitio
        public ActionResult Inicio()
        {
           ViewBag.ListaNoticia = BD.ObtenerTodasLasNoticias();
            return View();
        }

        public ActionResult Noticia()
        {
            
            return View();
        }

        public ActionResult Calendario()
        {
            return View();
        }

        public ActionResult TablaDeTalles()
        {
            return View();
        }



    }
}