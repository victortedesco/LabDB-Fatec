namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            n1Label = new Label();
            n2Label = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            n1Text = new TextBox();
            n2Text = new TextBox();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F);
            titleLabel.Location = new Point(273, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(252, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Operações Aritméticas";
            // 
            // n1Label
            // 
            n1Label.AutoSize = true;
            n1Label.Font = new Font("Segoe UI", 16F);
            n1Label.Location = new Point(146, 93);
            n1Label.Name = "n1Label";
            n1Label.Size = new Size(158, 30);
            n1Label.TabIndex = 1;
            n1Label.Text = "Informe o Nº 1";
            // 
            // n2Label
            // 
            n2Label.AutoSize = true;
            n2Label.Font = new Font("Segoe UI", 16F);
            n2Label.Location = new Point(146, 150);
            n2Label.Name = "n2Label";
            n2Label.Size = new Size(158, 30);
            n2Label.TabIndex = 2;
            n2Label.Text = "Informe o Nº 2";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.Window;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.Font = new Font("Segoe UI", 16F);
            calculateButton.Location = new Point(221, 310);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(124, 48);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calcular";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.Window;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 16F);
            clearButton.Location = new Point(463, 310);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(124, 48);
            clearButton.TabIndex = 4;
            clearButton.Text = "Limpar";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.Window;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 16F);
            exitButton.Location = new Point(664, 390);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(124, 48);
            exitButton.TabIndex = 5;
            exitButton.Text = "Sair";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // n1Text
            // 
            n1Text.Font = new Font("Segoe UI", 14F);
            n1Text.Location = new Point(487, 91);
            n1Text.Name = "n1Text";
            n1Text.Size = new Size(175, 32);
            n1Text.TabIndex = 7;
            n1Text.KeyPress += numericTextBox_KeyPress;
            // 
            // n2Text
            // 
            n2Text.Font = new Font("Segoe UI", 14F);
            n2Text.Location = new Point(487, 148);
            n2Text.Name = "n2Text";
            n2Text.Size = new Size(175, 32);
            n2Text.TabIndex = 8;
            n2Text.KeyPress += numericTextBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(n2Text);
            Controls.Add(n1Text);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(n2Label);
            Controls.Add(n1Label);
            Controls.Add(titleLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label n1Label;
        private Label n2Label;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private TextBox n1Text;
        private TextBox n2Text;
    }
}