
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

        private void editarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarAluno formEditarAluno = new frmEditarAluno();

            formEditarAluno.MdiParent = this;

            formEditarAluno.Show();

           
        }
    }
}