using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrjAcademia.Formularios
{
    public partial class frmEditarAluno : Form
    {

        string connectionString = "Server=localhost;DATABASE=db_academia; UID=root; PASSWORD='';";

        //Variável criada para pegar as informações do código do cliente
        int selectedId = 0;
        public frmEditarAluno()
        {
            InitializeComponent();
        }

        private void frmEditarAluno_Load(object sender, EventArgs e)
        {

        }
        private void DesabilitarCampos()
        {
            txtNomeAluno.Enabled = false;
            txtEndereco.Enabled = false;

        }
        private void HabilitarCampos()
        {
            txtNomeAluno.Enabled = true;
            txtEndereco.Enabled = true;
        }


        private void BuscarAluno(int codigo)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM tb_aluno WHERE id =@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", codigo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeAluno.Text = reader["nome"].ToString();
                                txtEndereco.Text = reader["endereco"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPeso.Text = reader["peso"].ToString();
                                txtAltura.Text = reader["altura"].ToString();
                                DateTime dataNascimento = reader.GetDateTime(reader.GetOrdinal("dataDeNascimento"));
                                dtpDataDeNascimento.Value = dataNascimento;
                                mtbTelefone.Text = reader["telefone"].ToString();
                                selectedId = Convert.ToInt32(reader["Id"]);
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao buscar Aluno" + ex.Message);
            }


        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (int.TryParse(txtCodigoALuno.Text, out codigo))
            {
                BuscarAluno(codigo);

            }
            else
            {
                MessageBox.Show("Por favor, inserir um código do aluno válido");
            }

        }

        public void LimparCampos()
        {

            txtNomeAluno.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            mtbTelefone.Text = "";
            dtpDataDeNascimento.Text = "";

        }

        private void AtualizarAluno(int id, string nome, DateOnly dataDeNascimento, string endereco, string telefone, string email, decimal peso, decimal altura, decimal imc)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE tb_aluno SET Nome = @nome, Data de Nascimento = @dataDeNascimento, Endereco = @endereco, Telefone = @telefone, Email = @email, Data de Matricula = @dataDeMatricula, Peso = @peso, Altura = @altura, Imc = @imc";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("dataDeNascimento", dataDeNascimento);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@peso", peso);
                        cmd.Parameters.AddWithValue("@altura", altura);
                        cmd.Parameters.AddWithValue("@imc", imc);
                        cmd.ExecuteNonQuery();
                        //Exibir uma mensagem de sucesso
                        MessageBox.Show("Dados atualizar com sucesso!");

                        //desabilitar os campos após a edição
                        DesabilitarCampos();

                        //Limpar os campos
                        LimparCampos();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (selectedId != 0)
            {
                //criando as variáveis
                string nome = txtNomeAluno.Text;
                string endereco = txtEndereco.Text;
                string email = txtEmail.Text;
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);
                string telefone = mtbTelefone.Text;
                DateTime dataDeNascimento = dtpDataDeNascimento.Value;




            
            }
        }

    }
}

