﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Vendas.br.com.projeto.MODEL
{
    public class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int qtd_estoque { get; set; }
        public int fornecedorID { get; set; }
    }
}
