using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_INS_INSTRUCAO")]
    public class MLInstrucao
    {
        public decimal? Codigo { get; set; }

        public decimal? FrequenciaMinutos { get; set; }

        public decimal? Quantidade { get; set; }

        public MLRemedio Remedio { get; set; }

        public bool Ativo { get; set; }
    }
}
