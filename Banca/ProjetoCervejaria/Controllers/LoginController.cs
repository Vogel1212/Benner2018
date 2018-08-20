using ProjetoCervejaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCervejaria.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Autentica(String login, String Senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Bussca(login, Senha);
            if (usuario != null)
            {
                Session["usuarioLogado"] = usuario;
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        private class UsuariosDAO
        {
            internal Usuario Busca(string login, string senha)
            {
                throw new NotImplementedException();
            }
        }
    }
}