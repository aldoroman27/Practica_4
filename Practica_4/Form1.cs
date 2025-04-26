using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        // Aquí mantenemos las variables definidas por el usuario
        private Dictionary<string, double> variables = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No es necesario código aquí a menos que uses el label.
        }

        private void analizarButton_Click(object sender, EventArgs e)
        {
            string input = expressionTextBox.Text;

            try
            {
                // Crear el Lexer
                Lexer lexer = new Lexer(input);
                List<Token> tokens = lexer.Tokenize();

                // Crear el Parser, pasando también las variables
                Parser parser = new Parser(tokens, variables);
                double result = parser.Parse();

                // Mostrar el resultado
                MessageBox.Show($"Resultado válido: {result}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar errores
                MessageBox.Show($"Error: {ex.Message}", "Error de análisis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            expressionTextBox.Clear();
        }
    }
}
