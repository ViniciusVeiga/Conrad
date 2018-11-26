using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_REC_RECEITA")]
    public class MLReceita
    {
        public decimal? Codigo { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public bool Ativo { get; set; }

        public List<string> Contatos { get; set; }

        public List<MLMedico> Medicos { get; set; }
    }
}
