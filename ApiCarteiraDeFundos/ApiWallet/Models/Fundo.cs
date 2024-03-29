﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWallet.Models
{
    public class Fundo
    {
        [Key]
        public int FundoId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public double Value { get; set; }

    }
}

