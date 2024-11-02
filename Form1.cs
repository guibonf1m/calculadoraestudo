using System;
using System.Windows.Forms;

namespace Calculadora2 {
    public partial class Form1 : Form {
        double valor1 = 0; 
        double valor2 = 0; 
        string operacao = ""; 
        bool operacaoselecionada = false; 

        public Form1() {
            InitializeComponent();
        }

        
        private void btnNumero_Click(object sender, EventArgs e) {
            Button button = (Button)sender; 
            string numero = button.Text; 

            
            if (textDisplay.Text == "0" || operacaoselecionada) {
                textDisplay.Clear();
            }

         
            textDisplay.Text += numero;
            operacaoselecionada = false; 
        }

        
        private void btnAdicionar_Click(object sender, EventArgs e) {
            valor1 = double.Parse(textDisplay.Text); 
            operacao = "+"; 
            operacaoselecionada = true; 
        }

        private void btnSubtracao_Click(object sender, EventArgs e) {
            valor1 = double.Parse(textDisplay.Text);
            operacao = "-";
            operacaoselecionada = true;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e) {
            valor1 = double.Parse(textDisplay.Text);
            operacao = "×";
            operacaoselecionada = true;
        }

        private void btnDivisao_Click(object sender, EventArgs e) {
            valor1 = double.Parse(textDisplay.Text);
            operacao = "÷";
            operacaoselecionada = true;
        }

        
        private void btnIgual_Click(object sender, EventArgs e) {
            valor2 = double.Parse(textDisplay.Text); 
            double resultado = 0;

            
            switch (operacao) {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "×":
                    resultado = valor1 * valor2;
                    break;
                case "÷":
                    if (valor2 != 0) {
                        resultado = valor1 / valor2;
                    }
                    else {
                        MessageBox.Show("Erro: Divisão por zero!");
                        return;
                    }
                    break;
            }

            textDisplay.Text = resultado.ToString(); 
        }

        
        private void btnCE_Click(object sender, EventArgs e) {
            if (textDisplay.Text.Length > 1) {
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1); 
            }
            else {
                textDisplay.Text = "0"; 
            }
        }

        
        private void btnLimpar_Click(object sender, EventArgs e) {
            textDisplay.Text = "0"; 
            valor1 = 0; 
            valor2 = 0;
            operacao = ""; 
            operacaoselecionada = false; 
        }

        
        private void btnVirgula_Click(object sender, EventArgs e) {
            if (!textDisplay.Text.Contains(",")) {
                textDisplay.Text += ","; 
            }
        }

        private void textDisplay_Click(object sender, EventArgs e) {
         
        }

        private void textDisplay_Click_1(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
