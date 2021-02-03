using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CategoriaDTO
    {
        private int id;
        private string descricao;

        public int ID
        {
            set { id = value; }
            get { return this.id; }
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
