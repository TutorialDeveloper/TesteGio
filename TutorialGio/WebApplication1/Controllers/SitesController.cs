using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SitesController : Controller
    {
        // GET: Sites
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDados()
        {
            List<Object> resultado = new List<object>();
            resultado.Add(new
            {
                Nome = "Linha de Código",
                URL = "www.linhadecodigo.com.br"
            });
            resultado.Add(new
            {
                Nome = "DevMedia",
                URL = "www.devmedia.com.br"
            });
            resultado.Add(new
            {
                Nome = "Mr. Bool",
                URL = "www.mrbool.com.br"
            });
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDadosInt(int quantidade)
        {
            List<Object> resultado = new List<object>();
            for (int i = 0; i < quantidade; i++)
            {
                resultado.Add(new { Nome = "Item " + i.ToString("000") });
            }
            return Json(resultado);
        }
    }
}