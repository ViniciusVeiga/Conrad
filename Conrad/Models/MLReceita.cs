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
        public MLReceita()
        {
            Instrucoes = new List<MLInstrucao>();
        }

        public decimal? Codigo { get; set; }

        public decimal? CreditosUso { get; set; }

        public decimal? CreditoUsados { get; set; }

        public DateTime Validade { get; set; }

        public DateTime DataEmissao { get; set; }

        public List<MLInstrucao> Instrucoes { get; set; }

        public bool QRCode { get; set; }

        public bool AssinaturaMedica { get; set; }

        public bool Ativo { get; set; }
    }
}
