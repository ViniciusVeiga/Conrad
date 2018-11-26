using Conrad.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conrad.Controllers
{
    public class ClinicaController : Controller
    {
        #region Index

        public ActionResult Index() => View();

        #endregion

        #region Item

        public ActionResult Item() => View();

        #region Salvar

        public ActionResult Salvar(MLClinica model)
        {
            // Salvar usuário aqui

            return View("Index");
        }

        #endregion

        #endregion
    }
}