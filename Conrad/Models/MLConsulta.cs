using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_CON_CONSULTA")]
    public class MLConsulta
    {
        public MLConsulta()
        {
            Observacoes = new List<string>();

            ObservacoesRetorno = new List<string>();

            Receitas = new List<MLReceita>();
        }

        public decimal? Codigo { get; set; }

        public string Relatorio { get; set; }

        public MLMedico Medico { get; set; }

        public MLClinica Clinica { get; set; }

        public DateTime? Data { get; set; }

        public DateTime? DataRetorno { get; set; }

        public List<MLReceita> Receitas { get; set; }

        public List<string> Observacoes { get; set; }

        public List<string> ObservacoesRetorno { get; set; }

        public bool Ativo { get; set; }
    }
}
