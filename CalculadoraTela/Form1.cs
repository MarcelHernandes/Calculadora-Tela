using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTela
{
    public partial class Form1 : Form
    {
        Model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NumeroUm_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Input Número UM

        private void NumeroDois_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Input Número DOIS

        private void Somar_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                Resultado.Text = "" + modelo.somar(num1, num2);
            }
        }//Fim do Botão Somar

        private void Subtrair_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                Resultado.Text = "" + modelo.Subtrair(num1, num2);
            }
        }//Fim do Botão Subtrair

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                if (modelo.Dividir(num1, num2) == -1)
                {
                    Resultado.Text = "Impossível Dividir";
                }
                else
                {
                    Resultado.Text = "" + modelo.Dividir(num1, num2);
                }
            }
        }//Fim do Botão Dividir

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                int num1 = Convert.ToInt32(NumeroUm.Text);
                int num2 = Convert.ToInt32(NumeroDois.Text);
                Resultado.Text = "" + modelo.Multiplicar(num1, num2);
            }
        }//Fim do Botão Multiplicar

        private void Limpar_Click(object sender, EventArgs e)
        {
            if (NumeroUm.Text == "" || NumeroDois.Text == "")
            {
                Resultado.Text = "Preencha os campos numéricos";
            }
            else
            {
                NumeroUm.Text = "";
                NumeroDois.Text = "";
                Resultado.Text = "";
            }
        }//Fim do Botão Limpar

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Resultado

    }//Fim da Classe

}//Fim do Projeto
