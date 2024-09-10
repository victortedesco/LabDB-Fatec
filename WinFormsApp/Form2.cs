namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            resultsBox.Items.Add("Resultados:");
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultsBox.Items.Clear();
            resultsBox.Items.Add("Resultados:");
            UpdateCount();
        }

        private void ExitButton_Click(Object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(n1TextBox.Text)) return;
            if (string.IsNullOrEmpty(n2TextBox.Text)) return;

            var n1 = double.Parse(n1TextBox.Text);
            var n2 = double.Parse(n2TextBox.Text);

            var result = $"{n1} + {n2} = {n1 + n2}";

            resultsBox.Items.Add(result);
            UpdateCount();
        }
        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(n1TextBox.Text)) return;
            if (string.IsNullOrEmpty(n2TextBox.Text)) return;

            var n1 = double.Parse(n1TextBox.Text);
            var n2 = double.Parse(n2TextBox.Text);

            var result = $"{n1} - {n2} = {n1 - n2}";

            resultsBox.Items.Add(result);
            UpdateCount();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(n1TextBox.Text)) return;
            if (string.IsNullOrEmpty(n2TextBox.Text)) return;

            var n1 = double.Parse(n1TextBox.Text);
            var n2 = double.Parse(n2TextBox.Text);

            var result = $"{n1} * {n2} = {n1 * n2}";

            resultsBox.Items.Add(result);
            UpdateCount();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(n1TextBox.Text)) return;
            if (string.IsNullOrEmpty(n2TextBox.Text)) return;

            var n1 = double.Parse(n1TextBox.Text);
            var n2 = double.Parse(n2TextBox.Text);

            if (n2 == 0)
            {
                MessageBox.Show("Não é possível (ainda) dividir por 0!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = $"{n1} / {n2} = {n1 / n2:f2}";

            resultsBox.Items.Add(result);
            UpdateCount();
        }

        private void ModuleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(n1TextBox.Text)) return;
            if (string.IsNullOrEmpty(n2TextBox.Text)) return;

            var n1 = double.Parse(n1TextBox.Text);
            var n2 = double.Parse(n2TextBox.Text);

            if (n2 == 0)
            {
                MessageBox.Show("Não é possível (ainda) dividir por 0!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = $"{n1} % {n2} = {n1 % n2:f2}";

            resultsBox.Items.Add(result);
            UpdateCount();
        }

        private void UpdateCount()
        {
            label4.Text = $"{resultsBox.Items.Count - 1} resultado(s)";
        }
    }
}
