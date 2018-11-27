using Conrad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conrad.Controllers
{
    public class PacienteController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            return View();
        }

        #region Listar

        public JsonResult Listar()
        {
            List<MLPaciente> list = new List<MLPaciente>();

            list.Add(new MLPaciente { Nome = "Jerson", Ativo = true });

            return Json(list);
        }

        #endregion

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            MLPaciente model = new MLPaciente();

            return View(model);
        }

        #region Salvar

        public ActionResult Salvar(MLPaciente model)
        {
            // Salvar usuário aqui

            return View("Index");
        }

        #endregion

        #endregion
    }
}