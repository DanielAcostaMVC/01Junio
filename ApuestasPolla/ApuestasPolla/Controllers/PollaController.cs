using ApuestasPolla.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApuestasPolla.Objetos;

namespace ApuestasPolla.Controllers
{
    public class PollaController : Controller
    {
        //
        // GET: /Polla/

        public ActionResult Index2(string a)
        {
            ViewBag.Recibido = a;
            return View();
        }

        public ActionResult Login(string Usuarios, string Contraseña)//string Option, string Value)
        {
            Conexion Conexion = new Conexion();
            Usuario Usuario = new Usuario();
            MetodosBaseDatos Consultar = new MetodosBaseDatos();
            Usuario = Consultar.Autenticar(Usuarios, Contraseña);
            if (Usuario.Id != 0)
            {
                Session["Usuario"] = Usuario.Id;
                return View(Usuario);
            }
            else
            {
                return RedirectToAction("Error", "Polla");
            }
        }

        public ActionResult Error()//string Option, string Value)
        {
            return View();
        }
    }
}
