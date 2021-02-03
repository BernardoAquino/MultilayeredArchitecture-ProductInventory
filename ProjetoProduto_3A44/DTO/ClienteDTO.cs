using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ClienteDTO
    {
        private int id, tipoUsuario;
        private string nome, endereco, uf, telefone, email, senha;

        public int ID
        {
            set { id = value; }
            get { return this.id; }
        }

        public int TipoUsuario
        {
            set { tipoUsuario = value; }
            get { return this.tipoUsuario; }
        }

        public string Nome
        {
            set 
            { 
                if(value != String.Empty)
                {
                    this.nome = value;
                }else
                {
                    throw new Exception("Favor preencher o <<nome>>.");
                }
            }
            get { return this.nome; }
        }

        public string Endereco
        {
            set
            {
                if (value != String.Empty)
                {
                    this.endereco = value;
                }
                else
                {
                    throw new Exception("Favor preencher o <<endereco>>.");
                }
            }
            get { return this.endereco; }
        }

        public string UF
        {
            set
            {
                if (value != String.Empty)
                {
                    this.uf = value;
                }
                else
                {
                    throw new Exception("Favor preencher a <<UF>>.");
                }
            }
            get { return this.uf; }
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

        public string Senha
        {
            set
            {
                if (value != String.Empty)
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("Favor preencher a <<senha>>.");
                }
            }
            get { return this.senha; }
        }
    }
}
