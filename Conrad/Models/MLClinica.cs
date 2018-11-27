using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_CLI_CLINICA")]
    public class MLClinica
    {
        public MLClinica()
        {
            Contatos = new List<string>();

            Medicos = new List<MLMedico>();        
        }

        public decimal? Codigo { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public bool Ativo { get; set; }

        public List<string> Contatos { get; set; }

        public List<MLMedico> Medicos { get; set; }
    }
}
