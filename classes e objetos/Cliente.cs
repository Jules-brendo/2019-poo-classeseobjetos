using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_e_objetos
{
    class Cliente
    {
        public string nome;
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;
        public Boolean EhMaiorDeIdade()
        {
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
