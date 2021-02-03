using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ProdutoDTO
    {
        private int id, categoria_id, fornecedor_id, quantidade;
        private double preco, peso;
        private string descricao;

        public int ID
        {
            set { id = value; }
            get { return this.id; }
        }

        public int Categoria_ID
        {
            set { categoria_id = value; }
            get { return this.categoria_id; }
        }

        public int Fornecedor_ID
        {
            set { fornecedor_id = value; }
            get { return this.fornecedor_id; }
        }

        public int Quantidade
        {
            set 
            {
                if (value > 0)
                {
                    quantidade = value;
                }
                else
                {
                    throw new Exception("Favor preencher a <<quantidade>> corretamente.");
                }
            }
            get { return this.quantidade; }
        }

        public double Preco
        {
            set
            { 
                if(value > 0)
                {
                    preco = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<preco>> corretamente.");
                }
            }
            get { return this.preco; }
        }

        public double Peso
        {
            set
            {
                if (value > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<peso>> corretamente.");
                }
            }
            get { return this.peso; }
        }

        public string Descricao
        {
            set
            {
                if (value != String.Empty)
                {
                    this.descricao = value;
                }
                else
                {
                    throw new Exception("Favor preencher a <<descrição>>.");
                }
            }
            get { return this.descricao; }

        }
    }
}
