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
            MLMedico model = new MLMedico();

            if (id == 1)
            {
                model = new MLMedico
                {
                    Codigo = 1,
                    Nome = "Jose Audaniso",
                    DataNascimento = Convert.ToDateTime("22/02/1980"),
                    Senha = "senhadojose",
                    Estado = "SP",
                    CRM = "391722",
                    Email = "ze@hotmail.com",
                    Cidade = "Itapetininga",
                    Ativo = true,
                    Telefone = "(13) 988119947"
                };
            }

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