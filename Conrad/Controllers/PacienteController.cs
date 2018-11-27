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

            return Json(list);
        }

        #endregion

        #endregion

        #region Item

        public ActionResult Item(decimal? id)
        {
            MLPaciente model = new MLPaciente();

            if (id == 1)
            {
                model = new MLPaciente
                {
                    Codigo = 1,
                    Nome = "Maria Joaquina",
                    DataNascimento = Convert.ToDateTime("25/02/1981"),
                    Senha = "senhadojose",
                    Estado = "SP",
                    Email = "moaquina@hotmail.com",
                    Cidade = "Itapetininga",
                    Ativo = true,
                    Telefone = "(13) 988332145",
                    Observacoes = new List<string> { "Dores fortes de cabeça na primeira análise.", "Paciente em analise de medicamentos fortes." }
                };
            }
            else if (id == 2)
            {
                model = new MLPaciente
                {
                    Codigo = 2,
                    Nome = "Francisco Ficoreio",
                    DataNascimento = Convert.ToDateTime("21/05/1981"),
                    Senha = "senhadojose",
                    Estado = "SP",
                    Email = "fran@hotmail.com",
                    Cidade = "Itapetininga",
                    Ativo = true,
                    Telefone = "(13) 988335535",
                    Observacoes = new List<string> { "Frescura.", "Recomendo um Psicólogo.", "Pode internar no Teixeira" }
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

        #region Receitar

        public ActionResult Receitar(decimal? id)
        {
            MLReceita model = new MLReceita();

            if (id == 1)
            {
                ViewBag.Nome = "Maria Joaquina";
            }
            else if (id == 2)
            {
                ViewBag.Nome = "Francisco Ficoreio";
            }

            return View(model);
        }

        #endregion
    }
}