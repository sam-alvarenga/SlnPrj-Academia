
using PrjAcademia.Formularios;

namespace PrjAcademia
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarAlunos formCadastrarAlunos = new frmCadastrarAlunos();

            formCadastrarAlunos.MdiParent = this;

            formCadastrarAlunos.Show();


        }
    }
}