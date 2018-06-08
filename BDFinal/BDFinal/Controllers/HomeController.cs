using System;
using BDFinal.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Activities.Expressions;

namespace BDFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Directorio(string ty)
        {
            if (ty == "1"){
                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetAmorTraductor();
                return View(model);
            }
            if (ty == "2")
                {
                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetActionTraductor();
                return View(model);
            }
            if (ty == "3")
            {
                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetDramaTraductor();
                return View(model);
              }
            else
            {
                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetAllTraductores();
                return View(model);

            }
        }
      

        public ActionResult Buscador(string generos)
        {
            if (generos == null || generos.Length == 0)
                {

                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetAllTraductores();
                return View(model);

            }
            else
            {
                var josue = new AccesoDatos.TraductorDataAccess();
                var model = josue.GetBuscadorTraductor(generos);
                return View(model);
            }

        }
    }
}