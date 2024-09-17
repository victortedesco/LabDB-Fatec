using System.Diagnostics;
using WinFormsApp.Form3Menus;

namespace WinFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmDialogResult = MessageBox.Show
            (
                "Deseja realmente fechar o programa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmDialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void BrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            if (File.Exists(edgePath))
            {
                Process.Start(edgePath);
                return;
            }
            
            MessageBox.Show("Microsoft Edge não encontrado. Verifique a instalação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void IMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new IMCForm();
            form.ShowDialog();
        }

        private void IdealMassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new IdealMassForm();
            form.ShowDialog();
        }
    }
}
