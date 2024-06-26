﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaPagar
    {
        public Compra Compra { get; set; }
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public EstadoPagamento Situacao { get; set; }
    }
}
