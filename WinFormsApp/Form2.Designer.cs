namespace WinFormsApp
{
    partial class Form2
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
            resultsBox = new ListBox();
            n1TextBox = new TextBox();
            n2TextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addButton = new Button();
            subtractButton = new Button();
            divideButton = new Button();
            multiplyButton = new Button();
            label3 = new Label();
            clearButton = new Button();
            exitButton = new Button();
            moduleButton = new Button();
            SuspendLayout();
            // 
            // resultsBox
            // 
            resultsBox.FormattingEnabled = true;
            resultsBox.ItemHeight = 15;
            resultsBox.Location = new Point(553, 30);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(203, 349);
            resultsBox.TabIndex = 0;
            // 
            // n1TextBox
            // 
            n1TextBox.Location = new Point(169, 70);
            n1TextBox.Name = "n1TextBox";
            n1TextBox.Size = new Size(149, 23);
            n1TextBox.TabIndex = 2;
            n1TextBox.KeyPress += NumericTextBox_KeyPress;
            // 
            // n2TextBox
            // 
            n2TextBox.Location = new Point(169, 128);
            n2TextBox.Name = "n2TextBox";
            n2TextBox.Size = new Size(149, 23);
            n2TextBox.TabIndex = 4;
            n2TextBox.KeyPress += NumericTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 52);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 5;
            label1.Text = "Informe um número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 110);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 6;
            label2.Text = "Informe outro número:";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 20F);
            addButton.Location = new Point(108, 240);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 50);
            addButton.TabIndex = 7;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Font = new Font("Segoe UI", 20F);
            subtractButton.Location = new Point(169, 240);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(50, 50);
            subtractButton.TabIndex = 8;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += SubtractButton_Click;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Segoe UI", 20F);
            divideButton.Location = new Point(281, 240);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(50, 50);
            divideButton.TabIndex = 9;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += DivideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 20F);
            multiplyButton.Location = new Point(225, 240);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(50, 50);
            multiplyButton.TabIndex = 10;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += MultiplyButton_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(108, 175);
            label3.Name = "label3";
            label3.Size = new Size(279, 49);
            label3.TabIndex = 11;
            label3.Text = "Informe os dados acima";
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 20F);
            clearButton.Location = new Point(108, 318);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(128, 50);
            clearButton.TabIndex = 12;
            clearButton.Text = "Limpar";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 20F);
            exitButton.Location = new Point(259, 318);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(128, 50);
            exitButton.TabIndex = 13;
            exitButton.Text = "Sair";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // moduleButton
            // 
            moduleButton.Font = new Font("Segoe UI", 20F);
            moduleButton.Location = new Point(337, 240);
            moduleButton.Name = "moduleButton";
            moduleButton.Size = new Size(50, 50);
            moduleButton.TabIndex = 14;
            moduleButton.Text = "%";
            moduleButton.UseVisualStyleBackColor = true;
            moduleButton.Click += ModuleButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moduleButton);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(label3);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(n2TextBox);
            Controls.Add(n1TextBox);
            Controls.Add(resultsBox);
            Name = "Form2";
            Text = "Operações Aritméticas";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ModuleButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox resultsBox;
        private TextBox n1TextBox;
        private TextBox n2TextBox;
        private Label label1;
        private Label label2;
        private Button addButton;
        private Button subtractButton;
        private Button divideButton;
        private Button multiplyButton;
        private Label label3;
        private Button clearButton;
        private Button exitButton;
        private Button moduleButton;
    }
}