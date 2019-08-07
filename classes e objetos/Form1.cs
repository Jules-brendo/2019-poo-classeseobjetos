using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classes_e_objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) 
        {
            Conta contaVictor = new Conta();
            //contaVictor.titular = "victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 100.0;

            Conta contaPedro = new Conta();
            //contaPedro.titular = "pedro";
            contaPedro.numero = 10;
            contaPedro.saldo = 550.0;

            contaVictor.Deposita(200);
            MessageBox.Show("Saldo: " + contaVictor.saldo);
            contaVictor.saca(50);
            MessageBox.Show("Saldo: " + contaVictor.saldo);

            contaPedro.Deposita(150);
            MessageBox.Show("Saldo: " + contaPedro.saldo);
            contaPedro.saca(100);
            MessageBox.Show("Saldo: " + contaPedro.saldo);
        }

        private void Button2_Click(object sender, EventArgs e) // a resposta é Letra D - MAURICIO 1800, GUILHERME 5200;
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta guilherme = new Conta();
            guilherme.saldo = 5000.0;

            mauricio.saldo -= 200.0;
            guilherme.saldo += 200.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("guilherme = " + guilherme.saldo);
        }

        private void Button3_Click(object sender, EventArgs e) // AS CONTAS SÃO DIFERENTES: Apesar dos dados dos dois objetos serem iguais, as referências são distintas; "==" VERIFICA as referências das variáveis e não os valores do objeto;
        {
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            //mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            //mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
        }

        private void Button4_Click(object sender, EventArgs e) // RESPOSTA: MAURICIO 3000 E COPIA 3000; não foi criado um novo objeto(cadê O NEW?) A linha Conta copia = mauricio apenas cria uma outra referência para a mesma Conta
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)// questão 13
        {
            Conta contaVictor = new Conta();
            //contaVictor.titular = "victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 300;
            contaVictor.idade = 15;

            //contaVictor.saca(50);
            //MessageBox.Show("saque: " + contaVictor.saca(200));
            if (contaVictor.saca(250) == true)
            {
                MessageBox.Show("saque reallizado com sucesso ");

            }
            else {
                MessageBox.Show("saque inválido");
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            Cliente cliente = new Cliente();
            conta.titular = cliente;
            conta.titular.nome = "Victor";
        }

        private void Button7_Click(object sender, EventArgs e) //R: guilherme silveira
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.nome = "Guilherme Silveira";
            umaConta.titular = guilherme;

            MessageBox.Show(umaConta.titular.nome);

        }

        private void Button8_Click(object sender, EventArgs e) //R:98765432-1
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.rg = "12345678-9";

            umaConta.titular = guilherme;
            umaConta.titular.rg = "98765432-1";

            MessageBox.Show(guilherme.rg);
        }
    }
}
