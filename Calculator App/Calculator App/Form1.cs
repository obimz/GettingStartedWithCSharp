using System;
using System.Data;

namespace Calculator_App
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void AppendToCalculationString(object sender, EventArgs e)
        {
            Button InvokeIn = sender as Button;
            if (InvokeIn != null)
            {
                resultBox.Text += InvokeIn.Text;
            }
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            resultBox.Text = string.Empty;
        }

        private void EvalauteCalculation(object sender, EventArgs e)
        {
            string expression = resultBox.Text;
            var result = new DataTable();
            try
            {
                double evaluateResult = Convert.ToDouble(result.Compute(expression, null));
                if (double.IsInfinity(evaluateResult) || double.IsNaN(evaluateResult))
                {
                    MessageBox.Show("Expression was evaluated to be undefined", "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultBox.Text = string.Empty;
                    return;
                }
                resultBox.Text = evaluateResult.ToString();
            }
            catch (System.Data.SyntaxErrorException)
            {
                MessageBox.Show("Expression was not valid", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultBox.Text = string.Empty;
            }
        }
    }
}
