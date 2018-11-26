using Conrad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conrad.Controllers
{
    public class UsuarioController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            return View();
        }

        #region Listar

        public JsonResult Listar()
        {
            List<MLUsuario> list = new List<MLUsuario>();

            list.Add(new MLUsuario { Nome = "Jerson", Ativo = true });

            return Json(list);
        }

        #endregion

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            MLUsuario model = new MLUsuario();

            return View(model);
        }

        #region Salvar

        public ActionResult Salvar(MLUsuario model)
        {
            // Salvar usuário aqui

            return View("Index");
        }

        #endregion

        #endregion
    }
}