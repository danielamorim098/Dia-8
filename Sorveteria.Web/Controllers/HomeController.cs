using Sorveteria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sorveteria.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var listaSorvete = new List<Sorvete>()
            {
                new Sorvete
                {
                    Sabor = "Morango",
                    Descricao = "Muito Bom",
                    Foto = "http://www.receitasdemae.com.br/wp-content/uploads/2013/01/sorvete-de-morango.jpg"
                    },


                 new Sorvete
                {
                    Sabor = "Chocolate",
                    Descricao = "Muito Bom",
                    Foto = "http://s.glbimg.com/po/rc/media/2013/01/03/09_27_31_109_sorvete.jpg"
                 },


                  new Sorvete
                {
                    Sabor = "Creme",
                    Descricao = "Muito Bom",
                    Foto = "http://www.sorvetecaseiro.com.br/wp-content/uploads/2013/04/sorvete-caseiro-de-creme.jpg"

            }
            };



            return View(listaSorvete);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}