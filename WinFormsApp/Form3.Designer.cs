namespace WinFormsApp
{
    partial class Form3
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
            menuStrip1 = new MenuStrip();
            calcularToolStripMenuItem = new ToolStripMenuItem();
            iMCToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            pesoIdealToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            programasToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            navegadorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { calcularToolStripMenuItem, programasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // calcularToolStripMenuItem
            // 
            calcularToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iMCToolStripMenuItem, toolStripSeparator2, pesoIdealToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem });
            calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            calcularToolStripMenuItem.Size = new Size(62, 20);
            calcularToolStripMenuItem.Text = "Calcular";
            // 
            // iMCToolStripMenuItem
            // 
            iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            iMCToolStripMenuItem.Size = new Size(180, 22);
            iMCToolStripMenuItem.Text = "IMC";
            iMCToolStripMenuItem.Click += IMCToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // pesoIdealToolStripMenuItem
            // 
            pesoIdealToolStripMenuItem.Name = "pesoIdealToolStripMenuItem";
            pesoIdealToolStripMenuItem.Size = new Size(180, 22);
            pesoIdealToolStripMenuItem.Text = "Peso Ideal";
            pesoIdealToolStripMenuItem.Click += IdealMassToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blocoDeNotasToolStripMenuItem, toolStripSeparator3, navegadorToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new Size(76, 20);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(154, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            blocoDeNotasToolStripMenuItem.Click += NotepadToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(151, 6);
            // 
            // navegadorToolStripMenuItem
            // 
            navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            navegadorToolStripMenuItem.Size = new Size(154, 22);
            navegadorToolStripMenuItem.Text = "Navegador";
            navegadorToolStripMenuItem.Click += BrowserToolStripMenuItem_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem calcularToolStripMenuItem;
        private ToolStripMenuItem iMCToolStripMenuItem;
        private ToolStripMenuItem pesoIdealToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem programasToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem navegadorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
    }
}