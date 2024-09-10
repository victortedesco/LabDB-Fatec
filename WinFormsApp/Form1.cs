namespace WinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        n1Text.Clear();
        n2Text.Clear();
        n1Text.Focus();
    }

    private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (sender is not TextBox textBox)
        {
            return;
        }

        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true;
        }

        if (e.KeyChar == '.' && textBox.Text.Contains('.'))
        {
            e.Handled = true;
        }
    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(n1Text.Text)) return;
            if (string.IsNullOrWhiteSpace(n2Text.Text)) return;

            double n1 = double.Parse(n1Text.Text.Replace(".", ","));
            double n2 = double.Parse(n2Text.Text.Replace(".", ","));

            var sum = n1 + n2;
            var subtraction = n1 - n2;
            var multiplication = n1 * n2;
            var division = n1 / n2;

            string result = string.Empty;

            result += $"A soma é: {sum:f2}\n";
            result += $"A subtração é: {subtraction:f2}\n";
            result += $"A multiplicação é: {multiplication:f2}\n";
            if (n2 != 0)
                result += $"A divisão é: {division:f2}";

            MessageBox.Show(result, "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        catch (Exception erro)
        {
            MessageBox.Show("Ocorreu um erro" + erro.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
