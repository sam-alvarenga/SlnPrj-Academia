using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;


namespace PrjAcademia.Formularios
{
    public partial class frmCadastrarAlunos : Form
    {
        string connectionString = "Server=localhost;DATABASE=db_academia; UID=root; PASSWORD='';";

        public frmCadastrarAlunos()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastrarAlunos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAluno.Text;
            DateOnly dataDeNascimento = DateOnly.FromDateTime(dtpDataDeNascimento.Value);
            DateTime dataDeMatricula = DateTime.Now;
            string email = txtEmail.Text;
            string telefone = mtbTelefone.Text;
            string endereco = txtEndereco.Text;
            decimal peso = Convert.ToDecimal(txtPeso.Text);
            decimal altura = Convert.ToDecimal(txtAltura.Text); 

            if (!decimal.TryParse(txtPeso.Text, out peso) || !decimal.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Peso e altura devem ser números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            altura /= 100;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefone) && !string.IsNullOrEmpty(endereco))
            {
                decimal imc = CalcularIMC(peso, altura);

                SalvarDados(nome, dataDeNascimento, dataDeMatricula, email, telefone, endereco, peso, altura, imc);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal CalcularIMC(decimal peso, decimal altura)
        {
            if (altura > 0)
            {
                return peso / (altura * altura);
            }
            else
            {
                MessageBox.Show("Altura deve ser maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void SalvarDados(string nome, DateOnly dataDeNascimento, DateTime dataDeMatricula, string email, string telefone, string endereco, decimal peso, decimal altura, decimal imc)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO tb_aluno(nome, dataDeNascimento, endereco, telefone, email, dataDeMatricula, peso, altura, imc) VALUES (@nome, @dataDeNascimento, @endereco, @telefone, @email, @dataDeMatricula, @peso, @altura, @imc)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@dataDeNascimento", dataDeNascimento.ToDateTime(new TimeOnly(0, 0)));
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@dataDeMatricula", dataDeMatricula);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@altura", altura * 100);
                        cmd.Parameters.AddWithValue("@imc", imc);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Dados Cadastrados com sucesso!\n IMC: {imc:N2};\n Classificação: {ClassificacaoIMC(imc)}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeAluno.Text = "";
                txtEndereco.Text = "";
                txtEmail.Text = "";
                dtpDataDeNascimento.Value = DateTime.Today;
                txtAltura.Text = "";
                txtPeso.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM tb_aluno";
                    //MySqlDataAdapter: Ele faz uma ponte do banco de dado com formulário
                    //query: como comando e conn como conexão 
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    //Criando um objeto para acessar as funções. DataTable: é uma função de tabela
                    DataTable dt = new DataTable();
                    //fill: É Para criar as colunas com as informações
                    da.Fill(dt);
                    //DataSource: Coloca as informações dentro do Grid
                    dgvDadosAlunos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados" + ex.Message);

            }
        }


        private string ClassificacaoIMC(decimal imc)
        {
            if (imc <= 18.5m)
            {
                return "Abaixo do Ideal";
            }
            else if (imc <= 24.9m)
            {
                return "Ideal";
            }
            else if (imc <= 29.9m)
            {
                return "Sobrepeso";
            }
            else if (imc <= 34.9m)
            {
                return "Obesidade Grau I";
            }
            else if (imc <= 39.9m)
            {
                return "Obesidade Grau II";
            }
            else // Caso imc > 40
            {
                return "Obesidade Grau III";
            }

        }

    }
}
