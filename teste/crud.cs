using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    abstract class Crud
    {
        public abstract bool ler();
        public abstract bool gravar();
        public abstract bool alterar();
        public abstract bool deletar();
    }
}
