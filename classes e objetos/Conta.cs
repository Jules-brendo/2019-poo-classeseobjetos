using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_e_objetos
{
    class Conta //Atributos e métodos de uma entidade do sistema.

    {
        public double saldo; 
        public Cliente titular;
        public int numero;
        public int idade;

        // Conta conta = new Conta(); - para instanciar um nova conta

        // questão 4
        //Conta c = new Conta();
        //c.saldo = 1000.0;
        //c.saldo += 200;

        public void Deposita(double valor)
        {
            saldo += valor;
        }
        public bool saca(double valor)
        {
            if (idade < 18)
            {
                if (valor > 200)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (valor <= this.saldo)
                {
                    this.saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void transfere(double valor, Conta destino)
        {
            this.saca(valor);
            destino.Deposita(valor);
        }

    }
}