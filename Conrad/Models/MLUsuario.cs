using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_USU_USUARIO")]
    public class MLUsuario
    {
        public decimal? Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public string Genero { get; set; }

        public DateTime? DataNascimento { get; set; }

        public bool Ativo { get; set; }
    }

    public class MLMedico : MLUsuario
    {
        public MLMedico()
        {
            Especialidades = new List<string>();
        }

        public string CRM { get; set; }

        public List<string> Especialidades { get; set; }

        public MLClinica Clinica { get; set; }
    }

    public class MLAssistente : MLUsuario
    {
        public MLClinica Clinica;
    }

    public class MLPaciente : MLUsuario
    {
        public MLPaciente()
        {
            Consultas = new List<MLConsulta>();

            Observacoes = new List<string>();
        }

        public List<MLConsulta> Consultas { get; set; }

        public List<string> Observacoes { get; set; }
    }
}
