using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class FornecedorDTO
    {
        private int id;
        private string nome, email, telefone;

        public int ID
        {
            set { id = value; }
            get { return this.id; }
        }

        public string Nome
        {
            set
            {
                if (value != String.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<nome>>.");
                }
            }
            get { return this.nome; }

        }

        public string Email
        {
            set
            {
                if (value != String.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<email>>.");
                }
            }
            get { return this.email; }

        }

        public string Telefone
        {
            set
            {
                if (value != String.Empty)
                {
                    this.telefone = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<telefone>>.");
                }
            }
            get { return this.telefone; }

        }
    }
}

