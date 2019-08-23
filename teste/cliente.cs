using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    
    class cliente : crud
    {
        private int id;
        private string nome;
        private string cep;
        private string cpf;
        private DAO dao;



        public string Nome { get => nome; set => nome = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cpf { get => cpf; set => cpf = value; }


        public cliente()
        {
            this.dao = DAO.instancia();
        }


        public override bool alterar()
        {
            throw new NotImplementedException();
        }

        public override bool deletar()
        {
            throw new NotImplementedException();
        }

        public override bool gravar()
        {
            /* Verificar se id existe
             */
            throw new NotImplementedException();

        }

        public override bool ler()
        {
            throw new NotImplementedException();
        }
    }
}
