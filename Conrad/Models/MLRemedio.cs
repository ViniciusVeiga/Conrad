using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Conrad.Model
{
    [Table("CON_REM_REMEDIO")]
    public class MLRemedio
    {
        public decimal? Codigo { get; set; }

        public string Nome { get; set; }

        public string Bula { get; set; }

        public string Manipuladora { get; set; }

        public bool Ativo { get; set; }
    }
}
