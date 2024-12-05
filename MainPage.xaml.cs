using Microsoft.Maui.Controls;

namespace MauiAppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularImcClicked(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores de peso e altura dos campos de entrada
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                // Verificar se os valores são válidos
                if (peso <= 0 || altura <= 0)
                {
                    lblResultado.Text = "Por favor, insira valores válidos para peso e altura.";
                    return;
                }

                // Calcular o IMC
                double imc = peso / (altura * altura);

                // Exibir o resultado com a categoria do IMC
                string resultado = $"IMC: {imc:F2}\n";

                if (imc < 18.5)
                    resultado += "Abaixo do peso.";
                else if (imc >= 18.5 && imc <= 24.9)
                    resultado += "Peso normal.";
                else if (imc >= 25 && imc <= 29.9)
                    resultado += "Sobrepeso.";
                else
                    resultado += "Obesidade.";

                lblResultado.Text = resultado;
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro em caso de exceções
                lblResultado.Text = "Erro: " + ex.Message;
            }
        }
    }
}
