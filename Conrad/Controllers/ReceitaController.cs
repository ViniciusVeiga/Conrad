using Conrad.Model;
using System;
using System.Web.Mvc;

namespace Conrad.Controllers
{
    public class ReceitaController : Controller
    {
        #region Index

        public ActionResult Index()
        {
            return View();
        }

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            MLReceita model = new MLReceita();

            if(id == 1)
            {
                ViewBag.Nome = "Maria Joaquina";
                model = new MLReceita
                {
                    Codigo = 1,
                    CreditosUso = 3,
                    CreditoUsados = 2,
                    DataEmissao = Convert.ToDateTime("23/02/2017"),
                    Validade = Convert.ToDateTime("22/02/2020")              
                };
            }

            return View(model);
        }

        #region Salvar

        public ActionResult Salvar(MLReceita model)
        {
            // Salvar usuário aqui

            return View("Index");
        }

        #endregion

        #endregion
    }
}