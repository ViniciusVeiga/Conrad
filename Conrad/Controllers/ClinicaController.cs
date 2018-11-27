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

        public ActionResult Item(decimal? id)
        {
            MLClinica model = new MLClinica();

            if (id == 1)
            {
                model = new MLClinica
                {
                    Codigo = 1,
                    Nome = "Clínica de Fisioterapia Hanna",
                    Endereco = "R. Figueredo dos Santos Coloridos",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Ativo = true
                };
            }
            else if (id == 2)
            {
                model = new MLClinica
                {
                    Codigo = 2,
                    Nome = "Clínica Movimente Fisioterapia Integrada",
                    Endereco = "R. Janeiro Feliz do Carvalho",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    Ativo = true
                };
            }

            return View(model);
        }

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